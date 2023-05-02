using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Osztaly
{
    class Kutyak
    {
        public static BinaryWriter writer;
        public static BinaryReader reader;

        string _fajta;
        string _neve;
        int _kora;

        public Kutyak(string fajta, string neve, int kora)
        {
            _fajta = fajta;
            _neve = neve;
            _kora = kora;
        }

        public Kutyak()
        {
            LoadFromFile();
        }

        public void SavetoFile()
        {
            Kutyak.writer.Write(_fajta);
            Kutyak.writer.Write(_neve);
            Kutyak.writer.Write(_kora);
        }

        public void LoadFromFile()
        {

            _fajta = Kutyak.reader.ReadString();
            _neve = Kutyak.reader.ReadString();
            _kora = Kutyak.reader.ReadInt32();
        }

        public void SetFajta(string value)
        {
            _fajta = value;
        }
        
        public string GetFajta()
        {
            return _fajta;
        }
        
        public void SetName(string value2)
        {
            _neve = value2;
        }


        public string GetName()
        {
            return _neve;
        }


        public void SetAge(int value3)
        {
           _kora = value3;
        }

        public int GetAge()
        {
            return _kora;
        }
    }
}
