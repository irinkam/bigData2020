using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gmap_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Настройки для компонента GMap.
            gMapControl1.Bearing = 0;

            //CanDragMap - Если параметр установлен в True,
            //пользователь может перетаскивать карту
            ///с помощью правой кнопки мыши.
            gMapControl1.CanDragMap = true;

            //Указываем, что перетаскивание карты осуществляется
            //с использованием левой клавишей мыши.
            //По умолчанию - правая.
            gMapControl1.DragButton = MouseButtons.Left;

            gMapControl1.GrayScaleMode = true;

            //MarkersEnabled - Если параметр установлен в True,
            //любые маркеры, заданные вручную будет показаны.
            //Если нет, они не появятся.
            gMapControl1.MarkersEnabled = true;

            //Указываем значение максимального приближения.
            gMapControl1.MaxZoom = 18;

            //Указываем значение минимального приближения.
            gMapControl1.MinZoom = 2;

            //Устанавливаем центр приближения/удаления
            //курсор мыши.
            gMapControl1.MouseWheelZoomType =
            GMap.NET.MouseWheelZoomType.MousePositionAndCenter;

            //Отказываемся от негативного режима.
            gMapControl1.NegativeMode = false;

            //Разрешаем полигоны.
            gMapControl1.PolygonsEnabled = true;

            //Разрешаем маршруты
            gMapControl1.RoutesEnabled = true;

            //Скрываем внешнюю сетку карты
            //с заголовками.
            gMapControl1.ShowTileGridLines = false;

            //Указываем, что при загрузке карты будет использоваться
            //18ти кратное приближение.
            gMapControl1.Zoom = 5;

            //Указываем что все края элемента управления
            //закрепляются у краев содержащего его элемента
            //управления(главной формы), а их размеры изменяются
            //соответствующим образом.
            //gMapControl1.Dock = DockStyle.Fill;

            //Указываем что будем использовать карты Google.
            gMapControl1.MapProvider =
            GMap.NET.MapProviders.GMapProviders.GoogleMap;
            GMap.NET.GMaps.Instance.Mode =
            GMap.NET.AccessMode.ServerOnly;

            //Если вы используете интернет через прокси сервер,
            //указываем свои учетные данные.
            GMap.NET.MapProviders.GMapProvider.WebProxy =
            System.Net.WebRequest.GetSystemWebProxy();
            GMap.NET.MapProviders.GMapProvider.WebProxy.Credentials =
            System.Net.CredentialCache.DefaultCredentials;

            //Создаем новый список маркеров, с указанием компонента
            //в котором они будут использоваться и названием списка
            GMap.NET.WindowsForms.GMapOverlay markersOverlay =
            new GMap.NET.WindowsForms.GMapOverlay(gMapControl1, "marker");

            //Инициализация нового ЗЕЛЕНОГО маркера, с указанием его координат
            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker1 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(56.484640, 84.947649));
            marker1.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker1);
            //Текст отображаемый при наведении на маркер
            marker1.ToolTipText = "Томск";

            //Инициализация нового маркера, с указанием его координат
            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker2 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(56.603185, 84.880913));
            marker2.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker2);
            //Текст отображаемый при наведении на маркер
            marker2.ToolTipText = "Северск";

            //Инициализация нового маркера, с указанием его координат
            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker3 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(55.354727, 86.088374));
            marker3.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker3);
            //Текст отображаемый при наведении на маркер
            marker3.ToolTipText = "Кемерово";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker4 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(53.720976, 91.44242300000001));
            marker4.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker4);
            //Текст отображаемый при наведении на маркер
            marker4.ToolTipText = "Абакан";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker5 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(64.539304,  40.518735));
            marker5.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker5);
            //Текст отображаемый при наведении на маркер
            marker5.ToolTipText = "Архангельск";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker6 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(51.128422, 71.430564));
            marker6.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker6);
            //Текст отображаемый при наведении на маркер
            marker6.ToolTipText = "Астана";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker7 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(46.347869,  48.033574));
            marker7.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker7);
            //Текст отображаемый при наведении на маркер
            marker7.ToolTipText = "Астрахань";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker8 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(53.356132,  83.74961999999999));
            marker8.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker8);
            //Текст отображаемый при наведении на маркер
            marker8.ToolTipText = "Барнаул";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker9 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(50.597467,  36.588849));
            marker9.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker9);
            //Текст отображаемый при наведении на маркер
            marker9.ToolTipText = "Белгород";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker10 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(52.541444,  85.219686));
            marker10.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker10);
            //Текст отображаемый при наведении на маркер
            marker10.ToolTipText = "Бийск";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker11 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(42.871027,  74.59452));
            marker11.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker11);
            //Текст отображаемый при наведении на маркер
            marker11.ToolTipText = "Бишкек";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker12 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(50.290658,  127.527173));
            marker12.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker12);
            //Текст отображаемый при наведении на маркер
            marker12.ToolTipText = "Благовещенск";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker13 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(56.151382,  101.634152));
            marker13.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker13);
            //Текст отображаемый при наведении на маркер
            marker13.ToolTipText = "Братск";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker14 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(53.2434,    34.364198));
            marker14.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker14);
            //Текст отображаемый при наведении на маркер
            marker14.ToolTipText = "Брянск";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker15 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(58.521475,  31.275475));
            marker15.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker15);
            //Текст отображаемый при наведении на маркер
            marker15.ToolTipText = "Великий Новгород";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker16 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(43.134019,  131.928379));
            marker16.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker16);
            //Текст отображаемый при наведении на маркер
            marker16.ToolTipText = "Владивосток";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker17 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(43.024122,  44.690476));
            marker17.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker17);
            //Текст отображаемый при наведении на маркер
            marker17.ToolTipText = "Владикавказ";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker18 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(56.129042,  40.40703));
            marker18.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker18);
            //Текст отображаемый при наведении на маркер
            marker18.ToolTipText = "Владимир";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker19 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(48.707103,   44.516939));
            marker19.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker19);
            //Текст отображаемый при наведении на маркер
            marker19.ToolTipText = "Волгоград";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker20 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(59.220492,  39.891568));
            marker20.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker20);
            //Текст отображаемый при наведении на маркер
            marker20.ToolTipText = "Вологда";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker21 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(51.661535,   39.200287));
            marker21.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker21);
            //Текст отображаемый при наведении на маркер
            marker21.ToolTipText = "Воронеж";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker22 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(43.317992,  45.698197));
            marker22.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker22);
            //Текст отображаемый при наведении на маркер
            marker22.ToolTipText = "Грозный";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker23 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(48.015877,  37.80285));
            marker23.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker23);
            //Текст отображаемый при наведении на маркер
            marker23.ToolTipText = "Донецк";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker24 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(56.838002,  60.597295));
            marker24.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker24);
            //Текст отображаемый при наведении на маркер
            marker24.ToolTipText = "Екатеринбург";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker25 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(57.000348,  40.973921));
            marker25.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker25);
            //Текст отображаемый при наведении на маркер
            marker25.ToolTipText = "Иваново";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker26 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(56.852775,  53.211463));
            marker26.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker26);
            //Текст отображаемый при наведении на маркер
            marker26.ToolTipText = "Ижевск";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker27 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(52.286387,  104.28066));
            marker27.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker27);
            //Текст отображаемый при наведении на маркер
            marker27.ToolTipText = "Иркутск";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker28 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(55.795793,  49.106585));
            marker28.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker28);
            //Текст отображаемый при наведении на маркер
            marker28.ToolTipText = "Казань";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker29 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(55.916229,  37.854467));
            marker29.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker29);
            //Текст отображаемый при наведении на маркер
            marker29.ToolTipText = "Калининград";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker30 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(54.507014,   36.252277));
            marker30.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker30);
            //Текст отображаемый при наведении на маркер
            marker30.ToolTipText = "Калуга";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker31 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(56.414897,   61.918905));
            marker31.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker31);
            //Текст отображаемый при наведении на маркер
            marker31.ToolTipText = "Каменск-Уральский";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker32 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(50.402395,  30.532690));
            marker32.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker32);
            //Текст отображаемый при наведении на маркер
            marker32.ToolTipText = "Киев";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker33 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(54.079033,  34.323163));
            marker33.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker33);
            //Текст отображаемый при наведении на маркер
            marker33.ToolTipText = "Киров";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker34 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(50.54986,    137.007867));
            marker34.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker34);
            //Текст отображаемый при наведении на маркер
            marker34.ToolTipText = "Комсомольск-на-Амуре";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker35 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(55.916229,  37.854467));
            marker35.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker35);
            //Текст отображаемый при наведении на маркер
            marker35.ToolTipText = "Королев";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker36 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(57.767683,  40.926418));
            marker36.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker36);
            //Текст отображаемый при наведении на маркер
            marker36.ToolTipText = "Кострома";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker37 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(45.023877,  38.970157));
            marker37.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker37);
            //Текст отображаемый при наведении на маркер
            marker37.ToolTipText = "Краснодар";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker38 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(56.008691,  92.870529));
            marker38.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker38);
            //Текст отображаемый при наведении на маркер
            marker38.ToolTipText = "Красноярск";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker39 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(51.730361,  36.192647));
            marker39.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker39);
            //Текст отображаемый при наведении на маркер
            marker39.ToolTipText = "Курск";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker40 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(52.61022,   39.594719));
            marker40.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker40);
            //Текст отображаемый при наведении на маркер
            marker40.ToolTipText = "Липецк";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker41 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(53.411677,  58.984415));
            marker41.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker41);
            //Текст отображаемый при наведении на маркер
            marker41.ToolTipText = "Магнитогорск";

            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker42 =
            new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
            new GMap.NET.PointLatLng(42.984913,  47.504646));
            marker42.ToolTip =
            new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker42);
            //Текст отображаемый при наведении на маркер
            marker42.ToolTipText = "Махачкала";

            //Добавляем маркеры в список маркеров
            markersOverlay.Markers.Add(marker1);
            markersOverlay.Markers.Add(marker2);
            markersOverlay.Markers.Add(marker3);
            markersOverlay.Markers.Add(marker4);
            markersOverlay.Markers.Add(marker5);
            markersOverlay.Markers.Add(marker6);
            markersOverlay.Markers.Add(marker7);
            markersOverlay.Markers.Add(marker8);
            markersOverlay.Markers.Add(marker9);
            markersOverlay.Markers.Add(marker10);
            markersOverlay.Markers.Add(marker11);
            markersOverlay.Markers.Add(marker12);
            markersOverlay.Markers.Add(marker13);
            markersOverlay.Markers.Add(marker14);
            markersOverlay.Markers.Add(marker15);
            markersOverlay.Markers.Add(marker16);
            markersOverlay.Markers.Add(marker17);
            markersOverlay.Markers.Add(marker18);
            markersOverlay.Markers.Add(marker19);
            markersOverlay.Markers.Add(marker20);
            markersOverlay.Markers.Add(marker21);
            markersOverlay.Markers.Add(marker22);
            markersOverlay.Markers.Add(marker23);
            markersOverlay.Markers.Add(marker24);
            markersOverlay.Markers.Add(marker25);
            markersOverlay.Markers.Add(marker26);
            markersOverlay.Markers.Add(marker27);
            markersOverlay.Markers.Add(marker28);
            markersOverlay.Markers.Add(marker29);
            markersOverlay.Markers.Add(marker30);
            markersOverlay.Markers.Add(marker31);
            markersOverlay.Markers.Add(marker32);
            markersOverlay.Markers.Add(marker33);
            markersOverlay.Markers.Add(marker34);
            markersOverlay.Markers.Add(marker35);
            markersOverlay.Markers.Add(marker36);
            markersOverlay.Markers.Add(marker37);
            markersOverlay.Markers.Add(marker38);
            markersOverlay.Markers.Add(marker39);
            markersOverlay.Markers.Add(marker40);
            markersOverlay.Markers.Add(marker41);
            markersOverlay.Markers.Add(marker42);

            //Добавляем в компонент, список маркеров
            gMapControl1.Overlays.Add(markersOverlay);
        }
    }
}
