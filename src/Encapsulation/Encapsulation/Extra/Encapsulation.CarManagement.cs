using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.CarManagement

/*
 * Tuliskan spesifikasi soal Anda disini. 
 * Kelas yang dibuat, atribut apa saja yang dibutuhkan, metode apa saja yang dibutuhkan, validasi atau aturan apa yang harus dilakukan.
 * CarManagement namespace Encapsulation.CarManagement.
 * Kelas publik yang bernama Car yang memiliki dua atribut private yaitu _brand (tipe string) dan _speed (tipe int). 
 * Sediakan properti publik dengan metode get dan set untuk kedua atribut tersebut.
 * Jika inputan untuk brand adalah null atau string kosong, maka set nilai variabel tersebut menjadi "Unknown".
 * Jika inputan untuk speed adalah negatif, maka set nilai speed menjadi 0.
 */


// Tulis disini


/*
 * Implementasikan solusi kelas dari soal Anda disini dan eksekusi implementasinya di Program.cs
 */

{
    public class Car
    {
        private string _brand;
        private int _speed;

        public string Brand
        {
            get { return _brand; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _brand = "Unknown";
                }
                else
                {
                    _brand = value;
                }
            }
        }
        public int Speed
        {
            get { return _speed; }
            set
            {
                if (value < 0)
                {
                    _speed = 0;
                }
                else
                {
                    _speed = value;
                }
            }
        }
        public Car(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }
    }
}
