// Autor. mgr. inż Piotr Bilski
// Programowanie Obiektowe
 
using System.Drawing;
using System.Threading;
using System.Windows.Forms;



namespace PO_W_506
{
    // ======== 1a ========
    public struct Point3D
    {
        public Point3D(double x, double y, double z)
        {
            X = x; Y = y; Z = z;
        }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    // ======== 1 ========
    class Figura
    {
        // deklaracja pól publicznych klasy Figura
        Color _kolorWypelnienia;
        Color _kolorLiniiObrysowej;
        protected Point3D _location;
        int _grubośćLiniiObrysowej;

        // deklaracja właściwości pozwalających na
        // manipulowanie wartościami pól prywatnych
        // zadeklarowanych w tej klasie
        public Color KolorWypełnienia
        {
            get { return _kolorWypelnienia; }
            set { _kolorWypelnienia = value; }
        }
        public Color KolorLiniiObrysowej
        {
            get { return _kolorLiniiObrysowej; }
            set { _kolorLiniiObrysowej = value; }
        }
        public int GrubośćLiniiObrysowej
        {
            get { return _grubośćLiniiObrysowej; }
            set { _grubośćLiniiObrysowej = value; }
        }
        public Point3D Location
        {
            get { return _location; }
            set { _location = value; }
        }
        public double X
        {
            get { return _location.X; }
            set { _location.X = value; }
        }
        public double Y
        {
            get { return _location.Y; }
            set { _location.Y = value; }
        }
    }

    // ======== 2 ========
    class Grafika2D : Figura
    { }
    class Grafika3D : Figura
    {
        public double Z
        {
            get { return _location.Z; }
            set { _location.Z = value; }
        }
    }

    // ======== 3 ========
    class Statyczne : Grafika3D
    { }
    class Obrotowe : Grafika3D
    {
        int _kierunkiemObrotu;
        double _nachylenieOsi;
        double _szybkośćObrotu;
    }

    // ======== 4 ========
    class Walec : Obrotowe
    {
        double _wysokosść;
        double _promień;
    }
    
    // ======== 5 ========
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Walec walec = new Walec();
            Thread.Sleep(1000000000);
        }
    }
}
