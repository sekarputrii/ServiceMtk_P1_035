using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FirstWCFService_035
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Matematika : IMatematika
    {
        public int Bagi(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //secara default
                //throw new Exception(ex.Message)   //pesan errorr secara default
                //throw new FaultException("Pesan Salah");  //untuk meloloskan pesan error yang dikirimkan ke client

                MathFault mf = new MathFault();
                mf.Kode = "Input yang anda masukkan salah";
                mf.Pesan = "Masukkan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }
        public int Kali(int a, int b)
        {
            try
            {
                return a * b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //secara default
                //throw new Exception(ex.Message)   //pesan errorr secara default
                //throw new FaultException("Pesan Salah");  //untuk meloloskan pesan error yang dikirimkan ke client

                MathFault mf = new MathFault();
                mf.Kode = "Input yang anda masukkan salah";
                mf.Pesan = "Masukkan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }
        public int Kurang(int a, int b)
        {
            try
            {
                return a - b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //secara default
                //throw new Exception(ex.Message)   //pesan errorr secara default
                //throw new FaultException("Pesan Salah");  //untuk meloloskan pesan error yang dikirimkan ke client

                MathFault mf = new MathFault();
                mf.Kode = "Input yang anda masukkan salah";
                mf.Pesan = "Masukkan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }
        public int Tambah(int a, int b)
        {
            try
            {
                return a + b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //secara default
                //throw new Exception(ex.Message)   //pesan errorr secara default
                //throw new FaultException("Pesan Salah");  //untuk meloloskan pesan error yang dikirimkan ke client

                MathFault mf = new MathFault();
                mf.Kode = "Input yang anda masukkan salah";
                mf.Pesan = "Masukkan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }
        //TKoordinat:nama methodnya, a,b = input seperti int.
        //Membuat koordinat hasil lalu menjumlahkan xa dengan xb, ya dengan yb lalu dimasukkan ke hasil
        public Koordinat TKoordinat(Koordinat a, Koordinat b)
        {
            try
            {
                Koordinat hasil = new Koordinat();
                hasil.X = a.X + b.X;
                hasil.Y = a.Y + b.Y;
                return hasil;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //secara default
                //throw new Exception(ex.Message)   //pesan errorr secara default
                //throw new FaultException("Pesan Salah");  //untuk meloloskan pesan error yang dikirimkan ke client

                MathFault mf = new MathFault();
                mf.Kode = "Input yang anda masukkan salah";
                mf.Pesan = "Masukkan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }
    }
}
