using System;
using System.IO;

namespace ProyectoFinal
{
    public class GeneradorArchivos
    {
        public void generarArchivo(string _cPaqueteria, bool _lEntrgado, string _cPeriodo, string _cMensaje)
        {
            var temp = _lEntrgado ? "Entregados" : "Pendientes";
            var cPeriodo = _cPeriodo.Split(' ')[1];

            var otra = cPeriodo.Substring(cPeriodo.Length - 1, 1);
            var tempPeriodo = otra != "s" ? (cPeriodo + "s") : cPeriodo;
            string path1 = $@"..\..\Bitacora\{_cPaqueteria}\{temp}";
            string path2 = $@"..\..\Bitacora\{_cPaqueteria}\{temp}\{tempPeriodo}.txt";

            crearArchivo(path1);

            if (!File.Exists(path2))
            {
                using (StreamWriter sw = File.CreateText(path2))
                {
                    sw.WriteLine(_cMensaje);
                    sw.Close();
                    sw.Dispose();
                }
            }
            else
            {
                File.AppendAllLines(path2, new String[] { _cMensaje });
            }
        }

        private void crearArchivo(string _cRuta)
        {
            if (!File.Exists(_cRuta))
            {
                Directory.CreateDirectory(_cRuta);
            }
        }

    }
}
