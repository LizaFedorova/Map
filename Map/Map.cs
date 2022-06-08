using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Windows.Forms;
namespace Map
{
    public partial class Map : Form
    {
        GMapOverlay plasticMarkersOverlay;
        public Map()
        {
            InitializeComponent();
            GMapOverlay plasticMarkersOverlay = new GMapOverlay(gMapControl1, "marker");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            gMapControl1.Bearing = 0; 
            gMapControl1.CanDragMap = true;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.GrayScaleMode = true;
            gMapControl1.MarkersEnabled = true;
            gMapControl1.MaxZoom = 18;
            gMapControl1.MinZoom = 2;
            gMapControl1.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.NegativeMode = false;
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Zoom = 12;
            gMapControl1.Dock = DockStyle.Fill;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMapControl1.Position = new PointLatLng(57.370469, 61.3948158);
            #region AddMarkers
            /*AddMarker(name, 57.384299, 61.398674);//1
            AddMarker(name, 57.388932, 61.392855);//2
            AddMarker(name, 57.361506, 61.394851);//3
            AddMarker(name, 57.373556, 61.42805);//4
            AddMarker(name, 57.367765, 61.428265);//5
            AddMarker(name, 57.371288, 61.384514);//6
            AddMarker(name, 57.372469, 61.383602);//7
            AddMarker(name, 57.370519, 61.384989);//8
            AddMarker(name, 57.389396, 61.398772);//9
            AddMarker(name, 57.366567, 61.432324);//10
            AddMarker(name, 57.363797, 61.428288);//11
            AddMarker(name, 57.364786, 61.433626);//12
            AddMarker(name, 57.363485, 61.436285);//13
            AddMarker(name, 57.312618, 61.332264);//14
            AddMarker(name, 57.371034, 61.410956);//15
            AddMarker(name, 57.367925, 61.404519);//16
            AddMarker(name, 57.364087, 61.418518);//17
            AddMarker(name, 57.364524, 61.419547);//18
            AddMarker(name, 57.362208, 61.439762);//19
            AddMarker(name, 57.371817, 61.410436);//20
            AddMarker(name, 57.358814, 61.400286);//21
            AddMarker(name, 57.359256, 61.398088);//22
            AddMarker(name, 57.356906, 61.395989);//23
            AddMarker(name, 57.356181, 61.392747);//24
            AddMarker(name, 57.356285, 61.395996);//25
            AddMarker(name, 57.356915, 61.394041);//26
            AddMarker(name, 57.356877, 61.394819);//27
            AddMarker(name, 57.376628, 61.370184);//28
            AddMarker(name, 57.348114, 61.362310);//29
            AddMarker(name, 57.344489, 61.362012);//30
            AddMarker(name, 57.350437, 61.363319);//31
            AddMarker(name, 57.350293, 61.362893);//32
            AddMarker(name, 57.368923, 61.425258);//33
            AddMarker(name, 57.372068, 61.417412);//34
            AddMarker(name, 57.341588, 61.335709);//35
            AddMarker(name, 57.344672, 61.345484);//36
            AddMarker(name, 57.345493, 61.348937);//37
            AddMarker(name, 57.337420, 61.323348);//38
            AddMarker(name, 57.341027, 61.331997);//39
            AddMarker(name, 57.347626, 61.367878);//40
            AddMarker(name, 57.366884, 61.409058);//41
            AddMarker(name, 57.375680, 61.374698);//42
            AddMarker(name, 57.375166, 61.371879);//43
            AddMarker(name, 57.387809, 61.403521);//44
            AddMarker(name, 57.369800, 61.337585);//45
            AddMarker(name, 57.339294, 61.320111);//46
            AddMarker(name, 57.359077, 61.391520);//47
            AddMarker(name, 57.359127, 61.393633);//48
            AddMarker(name, 57.368430, 61.401152);//49
            AddMarker(name, 57.364130, 61.392548);//50
            AddMarker(name, 57.364957, 61.391376);//51
            AddMarker(name, 57.360173, 61.384628);//52
            AddMarker(name, 57.362517, 61.387621);//53
            AddMarker(name, 57.374304, 61.361553);//54
            AddMarker(name, 57.374790, 61.391124);//55
            AddMarker(name, 57.373910, 61.386101);//56
            AddMarker(name, 56.885870, 60.616963);//57
            AddMarker(name, 57.370877, 61.428036);//58
            AddMarker(name, 57.372325, 61.388321);//59
            AddMarker(name, 57.372106, 61.385255);//60
            AddMarker(name, 57.371234, 61.380828);//61
            AddMarker(name, 57.370895, 61.382295);//62
            AddMarker(name, 57.370250, 61.375946);//63
            AddMarker(name, 57.371562, 61.371617);//64
            AddMarker(name, 57.382999, 61.394882);//65
            AddMarker(name, 57.372925, 61.390651);//66
            AddMarker(name, 57.369134, 61.373616);//67
            AddMarker(name, 57.368538, 61.371730);//68
            AddMarker(name, 57.369972, 61.372331);//69
            AddMarker(name, 57.365867, 61.361267);//70
            AddMarker(name, 57.366223, 61.359481);//71
            AddMarker(name, 57.368496, 61.439089);//72
            AddMarker(name, 57.366223, 61.443708);//73
            AddMarker(name, 57.346095, 61.345993);//74
            AddMarker(name, 57.373504, 61.369740);//75
            AddMarker(name, 57.372689, 61.369813);//76
            AddMarker(name, 57.371983, 61.366972);//77
            AddMarker(name, 57.371701, 61.365450);//78
            AddMarker(name, 57.371873, 61.365673);//79
            AddMarker(name, 57.372467, 61.364222);//80
            AddMarker(name, 57.374500, 61.375721);//81
            AddMarker(name, 57.373331, 61.375748);//82
            AddMarker(name, 57.341861, 61.364501);//83
            AddMarker(name, 57.343658, 61.364717);//84
            AddMarker(name, 57.344901, 61.364851);//85
            AddMarker(name, 57.345800, 61.365076);//86
            AddMarker(name, 57.344721, 61.364878);//87
            AddMarker(name, 57.375927, 61.373646);//88
            AddMarker(name, 57.370375, 61.421337);//89
            AddMarker(name, 57.375902, 61.373062);//90
            AddMarker(name, 57.368070, 61.331272);//91
            AddMarker(name, 57.363750, 61.394891);//92
            AddMarker(name, 57.357550, 61.403757);//93
            AddMarker(name, 57.357065, 61.401799);//94
            AddMarker(name, 57.355026, 61.404045);//95
            AddMarker(name, 57.354346, 61.399733);//96
            AddMarker(name, 57.361944, 61.399526);//97
            AddMarker(name, 57.347985, 61.400982);//98
            AddMarker(name, 57.344265, 61.341046);//99
            AddMarker(name, 57.367424, 61.341747);//100
            AddMarker(name, 57.355133, 61.455914);//101
            AddMarker(name, 57.341011, 61.403856);//102
            AddMarker(name, 57.340175, 61.402868);//103
            AddMarker(name, 57.340175, 61.402868);//104
            AddMarker(name, 57.341812, 61.403775);//105
            AddMarker(name, 57.380211, 61.390992);//106
            AddMarker(name, 57.378979, 61.392690);//107
            AddMarker(name, 57.376174, 61.396238);//108
            AddMarker(name, 57.371802, 61.389977);//109
            AddMarker(name, 57.373243, 61.394100);//110
            AddMarker(name, 57.371491, 61.386833);//111
            AddMarker(name, 57.370302, 61.354072);//112
            AddMarker(name, 57.341914, 61.363001);//113
            AddMarker(name, 57.344187, 61.363396);//114
            AddMarker(name, 57.345212, 61.363549);//115
            AddMarker(name, 57.345887, 61.363944);//116
            AddMarker(name, 57.363963, 61.342726);//117
            AddMarker(name, 57.365220, 61.343534);//118
            AddMarker(name, 57.364954, 61.440948);//119
            AddMarker(name, 57.372933, 61.380895);//120
            AddMarker(name, 57.366502, 61.427877);//121
            AddMarker(name, 57.367958, 61.416154);//122
            AddMarker(name, 57.369875, 61.367133);//123
            AddMarker(name, 57.370293, 61.368121);//124
            AddMarker(name, 56.911638, 60.828315);//125
            AddMarker(name, 56.913318, 60.821963);//126
            AddMarker(name, 56.903774, 60.815226);//127
            AddMarker(name, 57.359119, 61.403596);//128
            AddMarker(name, 57.356992, 61.405311);//129
            AddMarker(name, 57.355613, 61.405958);//130
            AddMarker(name, 57.355744, 61.405374);//131
            AddMarker(name, 57.379571, 61.383186);//132
            AddMarker(name, 57.375034, 61.387444);//133
            AddMarker(name, 57.374199, 61.381524);//134
            AddMarker(name, 57.372806, 61.358213);//135
            AddMarker(name, 57.371564, 61.378892);//136
            AddMarker(name, 57.372273, 61.376287);//137
            AddMarker(name, 57.373748, 61.377518);//138
            AddMarker(name, 57.362531, 61.391145);//139
            AddMarker(name, 57.343429, 61.346328);//140
            AddMarker(name, 57.342138, 61.341666);//141
            AddMarker(name, 57.364798, 61.432962);//142
            AddMarker(name, 56.901066, 60.817436);//143
            AddMarker(name, 56.900997, 60.820598);//144
            AddMarker(name, 56.899832, 60.816906);//145
            AddMarker(name, 56.899636, 60.816978);//146
            AddMarker(name, 56.807723, 59.923046);//147
            AddMarker(name, 57.380604, 61.391208);//148
            AddMarker("Прием металлолома", 57.323015, 61.325972);//149  
            AddMarker("Прием металлолома", 57.323861, 61.326457);//150
            AddMarker("Прием металлолома", 57.333889, 61.322828);//151 
            AddMarker("Прием вторсырья", 57.3655734, 61.4173321);//152
            AddMarker("Прием металлолома", 57.3223293, 61.329452);//153
            AddMarker("Прием вторсырья", 57.373467, 61.3923202);//154
            AddMarker("Пластмассовые и пластиковые изделия", 57.3713649, 61.4034665);//155
            AddMarker("Прием вторсырья", 57.373467, 61.3805823);//156 
            AddMarker("Утилизация отходов", 57.3647497, 61.3539354);//157 
            AddMarker("Утилизация отходов", 57.3401014, 61.3241831);//158*/
            #endregion

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = "Мусорный бак";
            GMapOverlay markersOverlay = new GMapOverlay(gMapControl1, "marker");
            void AddMarker(string newName, double lat, double lng)
            {
                GMapMarkerGoogleRed marker = new GMapMarkerGoogleRed(new PointLatLng(lat, lng));
                marker.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker);
                marker.ToolTipText = newName;
                markersOverlay.Markers.Add(marker);
            }
            #region AddMarkers
            AddMarker(name, 57.384299, 61.398674);//1
            AddMarker(name, 57.388932, 61.392855);//2
            AddMarker(name, 57.361506, 61.394851);//3
            AddMarker(name, 57.373556, 61.42805);//4
            AddMarker(name, 57.367765, 61.428265);//5
            AddMarker(name, 57.371288, 61.384514);//6
            AddMarker(name, 57.372469, 61.383602);//7
            AddMarker(name, 57.370519, 61.384989);//8
            AddMarker(name, 57.389396, 61.398772);//9
            AddMarker(name, 57.366567, 61.432324);//10
            AddMarker(name, 57.363797, 61.428288);//11
            AddMarker(name, 57.364786, 61.433626);//12
            AddMarker(name, 57.363485, 61.436285);//13
            AddMarker(name, 57.312618, 61.332264);//14
            AddMarker(name, 57.371034, 61.410956);//15
            AddMarker(name, 57.367925, 61.404519);//16
            AddMarker(name, 57.364087, 61.418518);//17
            AddMarker(name, 57.364524, 61.419547);//18
            AddMarker(name, 57.362208, 61.439762);//19
            AddMarker(name, 57.371817, 61.410436);//20
            AddMarker(name, 57.358814, 61.400286);//21
            AddMarker(name, 57.359256, 61.398088);//22
            AddMarker(name, 57.356906, 61.395989);//23
            AddMarker(name, 57.356181, 61.392747);//24
            AddMarker(name, 57.356285, 61.395996);//25
            AddMarker(name, 57.356915, 61.394041);//26
            AddMarker(name, 57.356877, 61.394819);//27
            AddMarker(name, 57.376628, 61.370184);//28
            AddMarker(name, 57.348114, 61.362310);//29
            AddMarker(name, 57.344489, 61.362012);//30
            AddMarker(name, 57.350437, 61.363319);//31
            AddMarker(name, 57.350293, 61.362893);//32
            AddMarker(name, 57.368923, 61.425258);//33
            AddMarker(name, 57.372068, 61.417412);//34
            AddMarker(name, 57.341588, 61.335709);//35
            AddMarker(name, 57.344672, 61.345484);//36
            AddMarker(name, 57.345493, 61.348937);//37
            AddMarker(name, 57.337420, 61.323348);//38
            AddMarker(name, 57.341027, 61.331997);//39
            AddMarker(name, 57.347626, 61.367878);//40
            AddMarker(name, 57.366884, 61.409058);//41
            AddMarker(name, 57.375680, 61.374698);//42
            AddMarker(name, 57.375166, 61.371879);//43
            AddMarker(name, 57.387809, 61.403521);//44
            AddMarker(name, 57.369800, 61.337585);//45
            AddMarker(name, 57.339294, 61.320111);//46
            AddMarker(name, 57.359077, 61.391520);//47
            AddMarker(name, 57.359127, 61.393633);//48
            AddMarker(name, 57.368430, 61.401152);//49
            AddMarker(name, 57.364130, 61.392548);//50
            AddMarker(name, 57.364957, 61.391376);//51
            AddMarker(name, 57.360173, 61.384628);//52
            AddMarker(name, 57.362517, 61.387621);//53
            AddMarker(name, 57.374304, 61.361553);//54
            AddMarker(name, 57.374790, 61.391124);//55
            AddMarker(name, 57.373910, 61.386101);//56
            AddMarker(name, 56.885870, 60.616963);//57
            AddMarker(name, 57.370877, 61.428036);//58
            AddMarker(name, 57.372325, 61.388321);//59
            AddMarker(name, 57.372106, 61.385255);//60
            AddMarker(name, 57.371234, 61.380828);//61
            AddMarker(name, 57.370895, 61.382295);//62
            AddMarker(name, 57.370250, 61.375946);//63
            AddMarker(name, 57.371562, 61.371617);//64
            AddMarker(name, 57.382999, 61.394882);//65
            AddMarker(name, 57.372925, 61.390651);//66
            AddMarker(name, 57.369134, 61.373616);//67
            AddMarker(name, 57.368538, 61.371730);//68
            AddMarker(name, 57.369972, 61.372331);//69
            AddMarker(name, 57.365867, 61.361267);//70
            AddMarker(name, 57.366223, 61.359481);//71
            AddMarker(name, 57.368496, 61.439089);//72
            AddMarker(name, 57.366223, 61.443708);//73
            AddMarker(name, 57.346095, 61.345993);//74
            AddMarker(name, 57.373504, 61.369740);//75
            AddMarker(name, 57.372689, 61.369813);//76
            AddMarker(name, 57.371983, 61.366972);//77
            AddMarker(name, 57.371701, 61.365450);//78
            AddMarker(name, 57.371873, 61.365673);//79
            AddMarker(name, 57.372467, 61.364222);//80
            AddMarker(name, 57.374500, 61.375721);//81
            AddMarker(name, 57.373331, 61.375748);//82
            AddMarker(name, 57.341861, 61.364501);//83
            AddMarker(name, 57.343658, 61.364717);//84
            AddMarker(name, 57.344901, 61.364851);//85
            AddMarker(name, 57.345800, 61.365076);//86
            AddMarker(name, 57.344721, 61.364878);//87
            AddMarker(name, 57.375927, 61.373646);//88
            AddMarker(name, 57.370375, 61.421337);//89
            AddMarker(name, 57.375902, 61.373062);//90
            AddMarker(name, 57.368070, 61.331272);//91
            AddMarker(name, 57.363750, 61.394891);//92
            AddMarker(name, 57.357550, 61.403757);//93
            AddMarker(name, 57.357065, 61.401799);//94
            AddMarker(name, 57.355026, 61.404045);//95
            AddMarker(name, 57.354346, 61.399733);//96
            AddMarker(name, 57.361944, 61.399526);//97
            AddMarker(name, 57.347985, 61.400982);//98
            AddMarker(name, 57.344265, 61.341046);//99
            AddMarker(name, 57.367424, 61.341747);//100
            AddMarker(name, 57.355133, 61.455914);//101
            AddMarker(name, 57.341011, 61.403856);//102
            AddMarker(name, 57.340175, 61.402868);//103
            AddMarker(name, 57.340175, 61.402868);//104
            AddMarker(name, 57.341812, 61.403775);//105
            AddMarker(name, 57.380211, 61.390992);//106
            AddMarker(name, 57.378979, 61.392690);//107
            AddMarker(name, 57.376174, 61.396238);//108
            AddMarker(name, 57.371802, 61.389977);//109
            AddMarker(name, 57.373243, 61.394100);//110
            AddMarker(name, 57.371491, 61.386833);//111
            AddMarker(name, 57.370302, 61.354072);//112
            AddMarker(name, 57.341914, 61.363001);//113
            AddMarker(name, 57.344187, 61.363396);//114
            AddMarker(name, 57.345212, 61.363549);//115
            AddMarker(name, 57.345887, 61.363944);//116
            AddMarker(name, 57.363963, 61.342726);//117
            AddMarker(name, 57.365220, 61.343534);//118
            AddMarker(name, 57.364954, 61.440948);//119
            AddMarker(name, 57.372933, 61.380895);//120
            AddMarker(name, 57.366502, 61.427877);//121
            AddMarker(name, 57.367958, 61.416154);//122
            AddMarker(name, 57.369875, 61.367133);//123
            AddMarker(name, 57.370293, 61.368121);//124
            AddMarker(name, 56.911638, 60.828315);//125
            AddMarker(name, 56.913318, 60.821963);//126
            AddMarker(name, 56.903774, 60.815226);//127
            AddMarker(name, 57.359119, 61.403596);//128
            AddMarker(name, 57.356992, 61.405311);//129
            AddMarker(name, 57.355613, 61.405958);//130
            AddMarker(name, 57.355744, 61.405374);//131
            AddMarker(name, 57.379571, 61.383186);//132
            AddMarker(name, 57.375034, 61.387444);//133
            AddMarker(name, 57.374199, 61.381524);//134
            AddMarker(name, 57.372806, 61.358213);//135
            AddMarker(name, 57.371564, 61.378892);//136
            AddMarker(name, 57.372273, 61.376287);//137
            AddMarker(name, 57.373748, 61.377518);//138
            AddMarker(name, 57.362531, 61.391145);//139
            AddMarker(name, 57.343429, 61.346328);//140
            AddMarker(name, 57.342138, 61.341666);//141
            AddMarker(name, 57.364798, 61.432962);//142
            AddMarker(name, 56.901066, 60.817436);//143
            AddMarker(name, 56.900997, 60.820598);//144
            AddMarker(name, 56.899832, 60.816906);//145
            AddMarker(name, 56.899636, 60.816978);//146
            AddMarker(name, 56.807723, 59.923046);//147
            AddMarker(name, 57.380604, 61.391208);//148
            #endregion
            gMapControl1.Overlays.Add(markersOverlay);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GMapOverlay markersOverlay = new GMapOverlay(gMapControl1, "marker");
            void AddMetall(string newName, double lat, double lng)
            {
                GMapMarkerGoogleRed marker = new GMapMarkerGoogleRed(new PointLatLng(lat, lng));
                marker.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker);
                marker.ToolTipText = newName;
                markersOverlay.Markers.Add(marker);
            }
            AddMetall("Прием металлолома \n Курская улица, 14/1", 57.323015, 61.325972);//149  
            AddMetall("Прием металлолома \n Курская улица, 10", 57.323861, 61.326457);//150
            AddMetall("Прием металлолома \n Курская улица, 4", 57.333889, 61.322828);//151 
            gMapControl1.Overlays.Add(markersOverlay);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GMapOverlay cMarkersOverlay = new GMapOverlay(gMapControl1, "marker");
            void AddCiro(string newName, double lat, double lng)
            {
                GMapMarkerGoogleRed marker = new GMapMarkerGoogleRed(new PointLatLng(lat, lng));
                marker.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker);
                marker.ToolTipText = newName;
                cMarkersOverlay.Markers.Add(marker);
            }
            AddCiro("Прием вторсырья \n Зеленая улица, 49А", 57.3654458, 61.4182588);//152
            AddCiro("Прием вторсырья \n Объездная улица", 57.3790566, 61.4153458);//154
            AddCiro("Прием вторсырья \n Советская улица, 1", 57.3737274, 61.3963579);//156 
            gMapControl1.Overlays.Add(cMarkersOverlay);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GMapOverlay plasticMarkersOverlay = new GMapOverlay(gMapControl1, "marker");
            void AddPlastic(string newName, double lat, double lng)
            {
                GMapMarkerGoogleRed marker = new GMapMarkerGoogleRed(new PointLatLng(lat, lng));
                marker.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker);
                marker.ToolTipText = newName;
                plasticMarkersOverlay.Markers.Add(marker);
            }
            AddPlastic("Пластмассовые и пластиковые изделия \n Советская улица, 11", 57.3713649, 61.4034665);//155 
            AddPlastic("Пластмассовые и пластиковые изделия \n Курская улица, 5", 57.3213, 61.3252123);
            gMapControl1.Overlays.Add(plasticMarkersOverlay);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GMapOverlay utilMarkersOverlay = new GMapOverlay(gMapControl1, "marker");
            void AddUtil(string newName, double lat, double lng)
            {
                GMapMarkerGoogleRed marker = new GMapMarkerGoogleRed(new PointLatLng(lat, lng));
                marker.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker);
                marker.ToolTipText = newName;
                utilMarkersOverlay.Markers.Add(marker);
            }
            AddUtil("Утилизация батареек \n Cтроителей, 1", 57.342639, 61.335429);//157 
            AddUtil("Утилизация батареек \n Космонавтов, 4", 57.358977, 61.391518);//158
            AddUtil("Утилизация батареек \n Фрунзе, 17", 57.372246, 61.378947);
            gMapControl1.Overlays.Add(utilMarkersOverlay);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (gMapControl1.Overlays.Count > 0)
            {
                gMapControl1.Overlays.RemoveAt(0);
                gMapControl1.Refresh();
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm fm = new MainForm();
            fm.Show();
        }
    }
}
