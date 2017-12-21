using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WindowsFormsApp1
{
    class XML
    {
        public static void Nacti(ref string zdroj, ref string cil, ref string Kamkopirovat)
        {

            using (XmlReader xr = XmlReader.Create(@"config.cfg"))
            {
                while (xr.Read())
                {
                    if (xr.NodeType == XmlNodeType.Element)
                    {
                        if (xr.Name == "Cesty")  //nazev elementu
                        {
                            zdroj = xr.GetAttribute("Zdroj");
                            cil = xr.GetAttribute("Cil");
                            Kamkopirovat = xr.GetAttribute("Kamkopirovat");
                        }
                    }
                }
            }



        }

        public static void Uloz(string zdroj, string cil, string Kamkopirova)
        {
            XmlWriterSettings set = new XmlWriterSettings();
            set.Indent = true;

            using (XmlWriter w = XmlWriter.Create(@"config.cfg", set))
            {
                w.WriteStartDocument();



                w.WriteStartElement("Cesty");
                w.WriteAttributeString("Zdroj", zdroj);
                w.WriteAttributeString("Cil", cil);
                w.WriteAttributeString("Kamkopirovat", Kamkopirova);
                w.WriteEndElement();


                w.WriteEndDocument();
                w.Flush();
            }

        }

    }
}
