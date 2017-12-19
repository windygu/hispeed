﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeoDo.RSS.DF.GPC
{
    /// <summary>
    /// 将ISCCP的GPC格式的D2数据值(byte)转换为物理量(float)
    /// CONVERT THAT DATA TO PHYSICAL VALUES
    /// </summary>
    public static class D2Data2Phys
    {
        private const float DLAT = 2.5f;//等经纬度分辨率

        /// <summary>
        /// 数据无效填充值，255
        /// </summary>
        private const byte IUNDEF = 255;

        /// <summary>
        /// 无效值转换后返回默认值，-1000.0f
        /// </summary>
        private const float RUNDEF = -1000.0f;

        #region 云顶大气压力查找表
        /// <summary>
        /// 云顶大气压力查找表
        /// </summary>
        private static  float[] PRETAB = new float[256]{
            -100.00f,  1.00f, 5.00f, 10.00f,15.00f,20.00f,25.00f,30.00f,35.00f,40.00f,
              45.00f, 50.00f, 55.00f,60.00f,65.00f,70.00f,75.00f,80.00f,85.00f,90.00f,
              95.00f,100.00f,105.00f,110.00f,115.00f,120.00f,125.00f,130.00f,135.00f,
             140.00f,145.00f,150.00f,155.00f,160.00f,165.00f,170.00f,175.00f,180.00f,
             185.00f,190.00f,195.00f,200.00f,205.00f,210.00f,215.00f,220.00f,225.00f,
             230.00f,235.00f,240.00f,245.00f,250.00f,255.00f,260.00f,265.00f,270.00f,
             275.00f,280.00f,285.00f,290.00f,295.00f,300.00f,305.00f,310.00f,315.00f,
             320.00f,325.00f,330.00f,335.00f,340.00f,345.00f,350.00f,355.00f,360.00f,
             365.00f,370.00f,375.00f,380.00f,385.00f,390.00f,395.00f,400.00f,405.00f,
             410.00f,415.00f,420.00f,425.00f,430.00f,435.00f,440.00f,445.00f,450.00f,
             455.00f,460.00f,465.00f,470.00f,475.00f,480.00f,485.00f,490.00f,495.00f,
             500.00f,505.00f,510.00f,515.00f,520.00f,525.00f,530.00f,535.00f,540.00f,
             545.00f,550.00f,555.00f,560.00f,565.00f,570.00f,575.00f,580.00f,585.00f,
             590.00f,595.00f,600.00f,605.00f,610.00f,615.00f,620.00f,625.00f,630.00f,
             635.00f,640.00f,645.00f,650.00f,655.00f,660.00f,665.00f,670.00f,675.00f,
             680.00f,685.00f,690.00f,695.00f,700.00f,705.00f,710.00f,715.00f,720.00f,
             725.00f,730.00f,735.00f,740.00f,745.00f,750.00f,755.00f,760.00f,765.00f,
             770.00f,775.00f,780.00f,785.00f,790.00f,795.00f,800.00f,805.00f,810.00f,
             815.00f,820.00f,825.00f,830.00f,835.00f,840.00f,845.00f,850.00f,855.00f,
             860.00f,865.00f,870.00f,875.00f,880.00f,885.00f,890.00f,895.00f,900.00f,
             905.00f,910.00f,915.00f,920.00f,925.00f,930.00f,935.00f,940.00f,945.00f,
             950.00f,955.00f,960.00f,965.00f,970.00f,975.00f,980.00f,985.00f,990.00f,
             995.00f,1000.00f,-200.00f,-200.00f,-200.00f,-200.00f,-200.00f,-200.00f,
             -200.00f,-200.00f,-200.00f,-200.00f,-200.00f,-200.00f,-200.00f,       
             -200.00f,-200.00f,-200.00f,-200.00f,-200.00f,-200.00f,-200.00f,       
             -200.00f,-200.00f,-200.00f,-200.00f,-200.00f,-200.00f,-200.00f,       
             -200.00f,-200.00f,-200.00f,-200.00f,-200.00f,-200.00f,-200.00f,       
             -200.00f,-200.00f,-200.00f,-200.00f,-200.00f,-200.00f,-200.00f,       
             -200.00f,-200.00f,-200.00f,-200.00f,-200.00f,-200.00f,-200.00f,       
             -200.00f,-200.00f,-200.00f,-200.00f,-200.00f,-1000.00f };
        #endregion

        #region 云顶温度查找表
        /// <summary>
        /// 云顶温度查找表
        /// </summary>
        private static float [] TMPTAB =new float[256]{
            -100.000f,165.000f,169.000f,172.000f,175.000f,177.800f,180.500f,       
            183.000f,185.500f,187.800f,190.000f,192.000f,194.000f,195.700f,       
            197.500f,199.200f,201.000f,202.700f,204.500f,206.200f,208.000f,       
            209.700f,211.500f,212.800f,214.100f,215.400f,216.700f,217.900f,       
            219.200f,220.500f,221.800f,223.100f,224.400f,225.400f,226.500f,       
            227.500f,228.600f,229.600f,230.600f,231.700f,232.700f,233.800f,       
            234.800f,235.700f,236.600f,237.500f,238.400f,239.200f,240.100f,       
            241.000f,241.900f,242.800f,243.700f,244.500f,245.300f,246.100f,       
            246.900f,247.700f,248.500f,249.300f,250.100f,250.900f,251.700f,       
            252.400f,253.100f,253.900f,254.600f,255.300f,256.000f,256.700f,       
            257.500f,258.200f,258.900f,259.500f,260.200f,260.800f,261.500f,       
            262.100f,262.800f,263.400f,264.100f,264.700f,265.400f,266.000f,       
            266.600f,267.200f,267.800f,268.400f,269.100f,269.700f,270.300f,       
            270.900f,271.500f,272.100f,272.700f,273.200f,273.800f,274.400f,       
            275.000f,275.600f,276.100f,276.700f,277.300f,277.800f,278.400f,       
            278.900f,279.500f,280.000f,280.500f,281.100f,281.600f,282.200f,       
            282.700f,283.200f,283.700f,284.200f,284.700f,285.200f,285.800f,       
            286.300f,286.800f,287.300f,287.800f,288.300f,288.800f,289.300f,       
            289.800f,290.200f,290.700f,291.200f,291.700f,292.200f,292.700f,       
            293.200f,293.600f,294.100f,294.600f,295.000f,295.500f,296.000f,       
            296.500f,296.900f,297.400f,297.800f,298.300f,298.700f,299.200f,       
            299.600f,300.100f,300.500f,301.000f,301.400f,301.900f,302.300f,       
            302.800f,303.200f,303.600f,304.000f,304.500f,304.900f,305.300f,       
            305.800f,306.200f,306.600f,307.000f,307.500f,307.900f,308.300f,       
            308.700f,309.100f,309.600f,310.000f,310.400f,310.800f,311.200f,       
            311.600f,312.000f,312.400f,312.900f,313.300f,313.700f,314.100f,       
            314.500f,314.900f,315.300f,315.700f,316.100f,316.400f,316.800f,       
            317.200f,317.600f,318.000f,318.400f,318.800f,319.200f,319.500f,       
            319.900f,320.300f,320.700f,321.100f,321.400f,321.800f,322.200f,       
            322.600f,323.000f,323.300f,323.700f,324.100f,324.500f,324.900f,       
            325.200f,325.600f,326.000f,326.400f,326.700f,327.100f,327.400f,       
            327.800f,328.200f,328.500f,328.900f,329.200f,329.600f,329.900f,       
            330.300f,330.600f,331.000f,331.300f,331.700f,332.000f,332.400f,       
            332.700f,333.100f,333.400f,333.800f,334.100f,334.500f,334.800f,       
            335.200f,335.500f,335.900f,336.200f,336.600f,336.900f,337.300f,       
            337.600f,338.000f,338.300f,338.600f,339.000f,339.300f,339.700f,       
            340.000f,345.000f,-200.000f,-1000.000f };

        /// <summary>
        /// 云顶温度Standard deviation查找表
        /// </summary>
        private static float[] TMPVAR = new float[256] { 
            -100.000f, 0.075f, 0.300f,0.600f,0.900f,1.200f,1.500f,1.800f,2.100f,2.400f,
               2.700f, 3.000f, 3.300f,3.600f,3.900f,4.200f,4.500f,4.800f,5.100f,5.400f,
               5.700f, 6.000f, 6.300f,6.600f,6.900f,7.200f,7.500f,7.800f,8.100f,8.400f,
               8.700f, 9.000f, 9.300f, 9.600f, 9.900f,10.200f,10.500f,10.800f,11.100f,
              11.400f,11.700f,12.000f,12.300f,12.600f,12.900f,13.200f,13.500f,13.800f,
              14.100f,14.400f,14.700f,15.000f,15.300f,15.600f,15.900f,16.200f,16.500f,
              16.800f,17.100f,17.400f,17.700f,18.000f,18.300f,18.600f,18.900f,19.200f,
              19.500f,19.800f,20.100f,20.400f,20.700f,21.000f,21.300f,21.600f,21.900f,
              22.200f,22.500f,22.800f,23.100f,23.400f,23.700f,24.000f,24.300f,24.600f,
              24.900f,25.200f,25.500f,25.800f,26.100f,26.400f,26.700f,27.000f,27.300f,
              27.600f,27.900f,28.200f,28.500f,28.800f,29.100f,29.400f,29.700f,30.000f,
              30.300f,30.600f,30.900f,31.200f,31.500f,31.800f,32.100f,32.400f,32.700f,
              33.000f,33.300f,33.600f,33.900f,34.200f,34.500f,34.800f,35.100f,35.400f,
              35.700f,36.000f,36.300f,36.600f,36.900f,37.200f,37.500f,37.800f,38.100f,
              38.400f,38.700f,39.000f,39.300f,39.600f,39.900f,40.200f,40.500f,40.800f,
              41.100f,41.400f,41.700f,42.000f,42.300f,42.600f,42.900f,43.200f,43.500f,
              43.800f,44.100f,44.400f,44.700f,45.000f,45.300f,45.600f,45.900f,46.200f,
              46.500f,46.800f,47.100f,47.400f,47.700f,48.000f,48.300f,48.600f,48.900f,
              49.200f,49.500f,49.800f,50.100f,50.400f,50.700f,51.000f,51.300f,51.600f,
              51.900f,52.200f,52.500f,52.800f,53.100f,53.400f,53.700f,54.000f,54.300f,
              54.600f,54.900f,55.200f,55.500f,55.800f,56.100f,56.400f,56.700f,57.000f,
              57.300f,57.600f,57.900f,58.200f,58.500f,58.800f,59.100f,59.400f,59.700f,
              60.000f,60.300f,60.600f,60.900f,61.200f,61.500f,61.800f,62.100f,62.400f,
              62.700f,63.000f,63.300f,63.600f,63.900f,64.200f,64.500f,64.800f,65.100f,
              65.400f,65.700f,66.000f,66.300f,66.600f,66.900f,67.200f,67.500f,67.800f,
              68.100f,68.400f,68.700f,69.000f,69.300f,69.600f,69.900f,70.200f,70.500f,
              70.800f,71.100f,71.400f,71.700f,72.000f,72.300f,72.600f,72.900f,73.200f,
              73.500f,73.800f,74.100f,74.400f,74.700f,75.400f,78.000f,85.000f,       
              -200.000f,-1000.000f};
        #endregion

        /// <summary>
        /// 水云的大气水路径常数6.292f，水云,water
        /// </summary>
        private const float PATHW = 6.292f;

        /// <summary>
        /// 冰云的大气水路径常数10.5f，冰云,ice
        /// </summary>
        private const float PATHI = 10.5f;

        #region 云光学厚度查找表
        /// <summary>
        /// 云光学厚度查找表
        /// </summary>
        private static float[] TAUTAB = new float[256] {
             -100.000f,0.020f,0.040f,0.060f,0.090f,0.110f,0.140f,0.160f,0.190f,0.220f, 
                0.240f,0.270f,0.300f,0.330f,0.370f,0.400f,0.430f,0.460f,0.500f,0.530f, 
                0.570f,0.600f,0.640f,0.680f,0.720f,0.750f,0.790f,0.830f,0.870f,0.920f, 
                0.960f,1.000f,1.040f,1.090f,1.130f,1.180f,1.220f,1.270f,1.320f,1.370f, 
                1.420f,1.470f,1.520f,1.570f,1.620f,1.670f,1.730f,1.780f,1.830f,1.890f, 
                1.950f,2.000f,2.060f,2.120f,2.180f,2.240f,2.300f,2.360f,2.430f,2.490f, 
                2.550f,2.620f,2.690f,2.750f,2.820f,2.890f,2.960f,3.030f,3.100f,3.180f, 
                3.250f,3.320f,3.400f,3.480f,3.550f,3.630f,3.710f,3.790f,3.880f,3.960f, 
                4.040f,4.130f,4.220f,4.300f,4.390f,4.480f,4.570f,4.670f,4.760f,4.850f, 
                4.950f,5.050f,5.150f,5.250f,5.350f,5.450f,5.560f,5.660f,5.770f,5.880f, 
                5.990f,6.110f,6.220f,6.340f,6.450f,6.570f,6.690f,6.820f,6.940f,7.070f, 
                7.190f,7.330f,7.460f,7.590f,7.730f,7.870f,8.010f,8.150f,8.300f,8.440f, 
                8.590f,8.740f,8.900f,9.060f,9.220f,9.380f,9.540f,9.710f,9.880f,10.050f,
              10.230f,10.410f,10.590f,10.780f,10.970f,11.160f,11.350f,11.550f,11.760f,
              11.960f,12.170f,12.390f,12.600f,12.830f,13.050f,13.280f,13.520f,13.760f,
              14.000f,14.250f,14.510f,14.770f,15.030f,15.300f,15.580f,15.860f,16.150f,
              16.440f,16.740f,17.050f,17.360f,17.690f,18.020f,18.350f,18.700f,19.050f,
              19.410f,19.780f,20.160f,20.540f,20.940f,21.350f,21.770f,22.200f,22.630f,
              23.080f,23.550f,24.030f,24.520f,25.020f,25.540f,26.070f,26.620f,27.190f,
              27.770f,28.370f,28.990f,29.630f,30.290f,30.970f,31.670f,32.400f,33.160f,
              33.940f,34.740f,35.580f,36.450f,37.350f,38.290f,39.260f,40.260f,41.320f,
              42.420f,43.570f,44.760f,46.000f,47.310f,48.680f,50.110f,51.600f,53.170f,
              54.840f,56.590f,58.430f,60.360f,62.400f,64.590f,66.900f,69.360f,71.960f,
              74.720f,77.730f,80.940f,84.380f,88.060f,92.020f,96.400f,101.010f,      
              105.510f,109.870f,114.330f,119.590f,125.920f,133.660f,143.120f,       
              154.650f, 169.560f, 187.490f, 207.200f, 228.130f, 250.440f, 282.780f, 
              323.920f, 378.650f,-200.000f,-200.000f,-200.000f,-200.000f,-200.000f, 
             -200.000f,-200.000f,-200.000f,-200.000f,-200.000f,-200.000f,          
             -1000.000f };
        #endregion

        #region 近地表反射率查找表
        /// <summary>
        /// 可见光波段地表的平均反射率(0-1.108)查找表
        /// </summary>
        private static float[] RFLTAB = new float[256]{
              -100.000f,0.000f,0.008f,0.012f,0.016f,0.020f,0.024f,0.028f,0.032f,0.036f, 
                 0.040f,0.044f,0.048f,0.052f,0.056f,0.060f,0.064f,0.068f,0.072f,0.076f, 
                 0.080f,0.084f,0.088f,0.092f,0.096f,0.100f,0.104f,0.108f,0.112f,0.116f, 
                 0.120f,0.124f,0.128f,0.132f,0.136f,0.140f,0.144f,0.148f,0.152f,0.156f, 
                 0.160f,0.164f,0.168f,0.172f,0.176f,0.180f,0.184f,0.188f,0.192f,0.196f, 
                 0.200f,0.204f,0.208f,0.212f,0.216f,0.220f,0.224f,0.228f,0.232f,0.236f, 
                 0.240f,0.244f,0.248f,0.252f,0.256f,0.260f,0.264f,0.268f,0.272f,0.276f, 
                 0.280f,0.284f,0.288f,0.292f,0.296f,0.300f,0.304f,0.308f,0.312f,0.316f, 
                 0.320f,0.324f,0.328f,0.332f,0.336f,0.340f,0.344f,0.348f,0.352f,0.356f, 
                 0.360f,0.364f,0.368f,0.372f,0.376f,0.380f,0.384f,0.388f,0.392f,0.396f, 
                 0.400f,0.404f,0.408f,0.412f,0.416f,0.420f,0.424f,0.428f,0.432f,0.436f, 
                 0.440f,0.444f,0.448f,0.452f,0.456f,0.460f,0.464f,0.468f,0.472f,0.476f, 
                 0.480f,0.484f,0.488f,0.492f,0.496f,0.500f,0.504f,0.508f,0.512f,0.516f, 
                 0.520f,0.524f,0.528f,0.532f,0.536f,0.540f,0.544f,0.548f,0.552f,0.556f, 
                 0.560f,0.564f,0.568f,0.572f,0.576f,0.580f,0.584f,0.588f,0.592f,0.596f, 
                 0.600f,0.604f,0.608f,0.612f,0.616f,0.620f,0.624f,0.628f,0.632f,0.636f, 
                 0.640f,0.644f,0.648f,0.652f,0.656f,0.660f,0.664f,0.668f,0.672f,0.676f, 
                 0.680f,0.684f,0.688f,0.692f,0.696f,0.700f,0.704f,0.708f,0.712f,0.716f, 
                 0.720f,0.724f,0.728f,0.732f,0.736f,0.740f,0.744f,0.748f,0.752f,0.756f, 
                 0.760f,0.764f,0.768f,0.772f,0.776f,0.780f,0.784f,0.788f,0.792f,0.796f, 
                 0.800f,0.804f,0.808f,0.812f,0.816f,0.820f,0.824f,0.828f,0.832f,0.836f, 
                 0.840f,0.844f,0.848f,0.852f,0.856f,0.860f,0.864f,0.868f,0.872f,0.876f, 
                 0.880f,0.884f,0.888f,0.892f,0.896f,0.900f,0.904f,0.908f,0.912f,0.916f, 
                 0.920f,0.924f,0.928f,0.932f,0.936f,0.940f,0.944f,0.948f,0.952f,0.956f, 
                 0.960f,0.964f,0.968f,0.972f,0.976f,0.980f,0.984f,0.988f,0.992f,1.000f, 
                 1.016f,1.040f,1.072f,1.108f,-200.000f,-1000.000f};
        #endregion

        #region 大气可降水查找表
        /// <summary>
        /// 平均可降水量(PW)查找表
        /// </summary>
        private static float[] PRWTAB = new float[256]{
              -100.000f,0.000f,0.030f,0.060f,0.090f,0.120f,0.150f,0.180f,0.210f,0.240f, 
               0.270f,0.300f,0.330f,0.360f,0.390f,0.420f,0.450f,0.480f,0.510f,0.540f,   
               0.570f,0.600f,0.630f,0.660f,0.690f,0.720f,0.750f,0.780f,0.810f,0.840f,   
               0.870f,0.900f,0.930f,0.960f,0.990f,1.020f,1.050f,1.080f,1.110f,1.140f,   
               1.170f,1.200f,1.230f,1.260f,1.290f,1.320f,1.350f,1.380f,1.410f,1.440f,   
               1.470f,1.500f,1.530f,1.560f,1.590f,1.620f,1.650f,1.680f,1.710f,1.740f,   
               1.770f,1.800f,1.830f,1.860f,1.890f,1.920f,1.950f,1.980f,2.010f,2.040f,   
               2.070f,2.100f,2.130f,2.160f,2.190f,2.220f,2.250f,2.280f,2.310f,2.340f,   
               2.370f,2.400f,2.430f,2.460f,2.490f,2.520f,2.550f,2.580f,2.610f,2.640f,   
               2.670f,2.700f,2.730f,2.760f,2.790f,2.820f,2.850f,2.880f,2.910f,2.940f,   
               2.970f,3.000f,3.030f,3.060f,3.090f,3.120f,3.150f,3.180f,3.210f,3.240f,   
               3.270f,3.300f,3.330f,3.360f,3.390f,3.420f,3.450f,3.480f,3.510f,3.540f,   
               3.570f,3.600f,3.630f,3.660f,3.690f,3.720f,3.750f,3.780f,3.810f,3.840f,   
               3.870f,3.900f,3.930f,3.960f,3.990f,4.020f,4.050f,4.080f,4.110f,4.140f,   
               4.170f,4.200f,4.230f,4.260f,4.290f,4.320f,4.350f,4.380f,4.410f,4.440f,   
               4.470f,4.500f,4.530f,4.560f,4.590f,4.620f,4.650f,4.680f,4.710f,4.740f,   
               4.770f,4.800f,4.830f,4.860f,4.890f,4.920f,4.950f,4.980f,5.010f,5.040f,   
               5.070f,5.100f,5.130f,5.160f,5.190f,5.220f,5.250f,5.280f,5.310f,5.340f,   
               5.370f,5.400f,5.430f,5.460f,5.490f,5.520f,5.550f,5.580f,5.610f,5.640f,   
               5.670f,5.700f,5.730f,5.760f,5.790f,5.820f,5.850f,5.880f,5.910f,5.940f,   
               5.970f,6.000f,6.030f,6.060f,6.090f,6.120f,6.150f,6.180f,6.210f,6.240f,   
               6.270f,6.300f,6.330f,6.360f,6.390f,6.420f,6.450f,6.480f,6.510f,6.540f,   
               6.570f,6.600f,6.630f,6.660f,6.690f,6.720f,6.750f,6.780f,6.810f,6.840f,   
               6.870f,6.900f,6.930f,6.960f,6.990f,7.020f,7.050f,7.080f,7.110f,7.140f,   
               7.170f,7.200f,7.230f,7.260f,7.290f,7.320f,7.350f,7.380f,7.410f,7.440f,   
               7.470f,7.500f,7.650f,8.000f,-200.000f,-1000.000f};
        #endregion

        #region 臭氧浓度查找表
        /// <summary>
        /// 平均臭氧柱状浓度查找表
        /// </summary>
        private static float[] OZNTAB = new float[256]{
              -100.0f,0.0f,2.0f,4.0f,6.0f,8.0f,10.0f,12.0f,14.0f,16.0f,18.0f,20.0f,22.0f,  
               24.0f,26.0f,28.0f,30.0f,32.0f,34.0f,36.0f,38.0f,40.0f,42.0f,44.0f,46.0f,   
               48.0f,50.0f,52.0f,54.0f,56.0f,58.0f,60.0f,62.0f,64.0f,66.0f,68.0f,70.0f,   
               72.0f,74.0f,76.0f,78.0f,80.0f,82.0f,84.0f,86.0f,88.0f,90.0f,92.0f,94.0f,   
               96.0f,98.0f,100.0f,102.0f,104.0f,106.0f,108.0f,110.0f,112.0f,114.0f,     
               116.0f,118.0f,120.0f,122.0f,124.0f,126.0f,128.0f,130.0f,132.0f,134.0f,   
               136.0f,138.0f,140.0f,142.0f,144.0f,146.0f,148.0f,150.0f,152.0f,154.0f,   
               156.0f,158.0f,160.0f,162.0f,164.0f,166.0f,168.0f,170.0f,172.0f,174.0f,   
               176.0f,178.0f,180.0f,182.0f,184.0f,186.0f,188.0f,190.0f,192.0f,194.0f,   
               196.0f,198.0f,200.0f,202.0f,204.0f,206.0f,208.0f,210.0f,212.0f,214.0f,   
               216.0f,218.0f,220.0f,222.0f,224.0f,226.0f,228.0f,230.0f,232.0f,234.0f,   
               236.0f,238.0f,240.0f,242.0f,244.0f,246.0f,248.0f,250.0f,252.0f,254.0f,   
               256.0f,258.0f,260.0f,262.0f,264.0f,266.0f,268.0f,270.0f,272.0f,274.0f,   
               276.0f,278.0f,280.0f,282.0f,284.0f,286.0f,288.0f,290.0f,292.0f,294.0f,   
               296.0f,298.0f,300.0f,302.0f,304.0f,306.0f,308.0f,310.0f,312.0f,314.0f,   
               316.0f,318.0f,320.0f,322.0f,324.0f,326.0f,328.0f,330.0f,332.0f,334.0f,   
               336.0f,338.0f,340.0f,342.0f,344.0f,346.0f,348.0f,350.0f,352.0f,354.0f,   
               356.0f,358.0f,360.0f,362.0f,364.0f,366.0f,368.0f,370.0f,372.0f,374.0f,   
               376.0f,378.0f,380.0f,382.0f,384.0f,386.0f,388.0f,390.0f,392.0f,394.0f,   
               396.0f,398.0f,400.0f,402.0f,404.0f,406.0f,408.0f,410.0f,412.0f,414.0f,   
               416.0f,418.0f,420.0f,422.0f,424.0f,426.0f,428.0f,430.0f,432.0f,434.0f,   
               436.0f,438.0f,440.0f,442.0f,444.0f,446.0f,448.0f,450.0f,452.0f,454.0f,   
               456.0f,458.0f,460.0f,462.0f,464.0f,466.0f,468.0f,470.0f,472.0f,474.0f,   
               476.0f,478.0f,480.0f,482.0f,484.0f,486.0f,488.0f,490.0f,492.0f,494.0f,   
               496.0f,498.0f,500.0f,505.0f,515.0f,-200.0f,-1000.0f};
        #endregion

        public static float Data2Phys(byte d2data, int bandNO)
        {
            float phys = 0.0f;
            if(bandNO==1)//纬度索引值
            {
                if (d2data == IUNDEF)
                    phys = RUNDEF;
                else
                    phys = (d2data - 1) * DLAT + DLAT / 2.0f - 90;
                return phys;
            }
            else if (bandNO >= 2 && bandNO <= 7)//经度索引值,像素土地类型,观测值个数及白天观测值个数；
            {
                return d2data;
            }
            //else if(bandNO==5)//像素土地类型
            //{
            //    return d2data;
            //}
            //else if(bandNO==6||bandNO==7)//观测值个数及白天观测值个数；
            //{
            //    return d2data;
            //}
            else if (bandNO == 8||bandNO == 9)//云量，CLOUD AMOUNTS 
            {
                if (d2data == IUNDEF)
                    phys = RUNDEF;
                else
                    phys = d2data*0.5f;
                return phys;
            }
            else if (bandNO >= 10&&bandNO <= 19)//云量的统计分布，FREQUENCY DISTRIBUTION
            {
                if (d2data == IUNDEF)
                    phys = RUNDEF;
                else
                    phys = d2data * 0.5f;
                return phys;
            }
            else if (bandNO >= 20 && bandNO <= 22)//云顶压力，CONVERT AVERAGE AND VARIANCE OF THE CLOUD TOP PRESSURE 
            {
                phys = PRETAB[d2data];
                return phys;
            }
            else if (bandNO >= 23 && bandNO <= 25)//云顶温度，MEAN CLOUD TOP TEMPERATURE (TC)
            {
                if (bandNO == 23)
                    phys = TMPTAB[d2data];
                else
                    phys = TMPVAR[d2data];
                return phys;
            }
            else if (bandNO >= 26&&bandNO <= 31)//计算云水路径及大气光学厚度CONVERT TAU AND PATH 
            {
                phys = TAUTAB[d2data];
                if (bandNO >= 29&&bandNO <= 31)
                    if (phys>=0)
                        phys = phys * PATHW;
                    
                return phys;
            }
            else if (bandNO>=32&&bandNO<=40)//近红外云类型的云量、云顶压力、云顶温度，IR CLOUD TYPES
            {
                if ((bandNO-32)%3 ==0)// 32,35,38)
                {
                    if (d2data == IUNDEF)
                        phys = RUNDEF;
                    else
                        phys = d2data * 0.5f;//云量
                }
                else if ((bandNO - 33) % 3 == 0)//33,36,39
                    phys = PRETAB[d2data];//云顶压力
                else//34,37,40
                    phys = TMPTAB[d2data];//云顶温度
                return phys;
            }
            else if (bandNO >= 41 && bandNO <= 115)//可见光/红外/近红外通道探测的低云/中云/高云类型（仅白天有效）VIS/IR/NIR LOW-LEVEL CLOUD TYPES
            {
                //int dis = (bandNO - 41) % 5;
                if ((bandNO - 41) % 5 == 0)//band41、46、51、56、61、66、71、76、81、86、91、96、101、106、111，15种CA
                {
                    if (d2data == IUNDEF)
                        phys = RUNDEF;
                    else
                        phys = d2data * 0.5f;//云量
                }
                else if ((bandNO - 41) % 5 == 1)
                    phys = PRETAB[d2data];//云顶压力
                else if ((bandNO - 41) % 5 == 2)
                    phys = TMPTAB[d2data];//云顶温度
                else if ((bandNO - 41) % 5 == 3 || (bandNO - 41) % 5 == 4)
                {
                    phys = TAUTAB[d2data];//云光学厚度和云的大气水路径
                    if ((bandNO - 41) % 5 == 4)//云水路径
                    {
                        if (phys>=0)
                        {
                            if (bandNO <= 55 || (bandNO >= 71 && bandNO <= 85))
                                phys = phys * PATHW;//水云,water
                            else
                                phys = phys * PATHI;//冰云，ice
                        }                        
                    }
                }
                return phys;
            }
            else if (bandNO == 116 || bandNO == 117)//地表表层平均温度(165-345 K) MEAN SURFACE SKIN TEMPERATURE (TS)
            {
                phys = TMPTAB[d2data];
                return phys;
            }
            else if (bandNO == 118)//可见光波段地表的平均反射率(0-1.108)（仅白天有效） MEAN SURFACE VISIBLE REFLECTANCE (RS)
            {
                phys = RFLTAB[d2data];
                return phys;
            }
            else if (bandNO == 119)//冰雪覆盖程度ICE/SNOW COVER
            {
                if (d2data == IUNDEF)
                    phys = RUNDEF;
                else
                    phys = d2data * 1.0f;
                return phys;
            }
            else if (bandNO == 120 )//地表表层气压，SURFACE PRESSURE 
            {
                phys = PRETAB[d2data];
                return phys;
            }
            else if (bandNO == 121)//近地表表层温度，SURFACE TEMPERATURE   
            {
                phys = TMPTAB[d2data];
                return phys;
            }
            else if (bandNO >= 122 && bandNO <= 124)//3个标准压力层(740,500,375 mb）的大气温度
            {
                phys = TAUTAB[d2data];
                return phys;
            }
            else if (bandNO == 125)//对流层顶气压Mean Tropopause pressure (PT)
            {
                phys = PRETAB[d2data];
                return phys;
            }
            else if (bandNO == 126)//对流层顶温度，Mean Tropopause temperature (TT)
            {
                phys = TMPTAB[d2data];
                return phys;
            }
            else if (bandNO == 127)//对流层顶温度at 50 mb，Mean Stratosphere temperature at 50 mb (T)
            {
                phys = TMPTAB[d2data];
                return phys;
            }
            else if (bandNO == 128 || bandNO == 129)//CONVERT PRECIPITABLE WATER FOR 2 STANDARD PRESSURE LEVELS (1000-680, 680-310 mb) 
            {
                phys = PRWTAB[d2data];
                return phys;
            }
            else if (bandNO == 130)//CONVERT O3-OZONE ABUNDANCE
            {
                phys = OZNTAB[d2data];
                return phys;
            }
            return d2data;
        }

    }
}
