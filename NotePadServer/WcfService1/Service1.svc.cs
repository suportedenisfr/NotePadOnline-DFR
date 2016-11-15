using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;


namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string ReturnText(string id)
        {
            string txt = "";

            BlocoNotasEntities1 db = new BlocoNotasEntities1();

            TB_TEXTO txtobj = new TB_TEXTO();

            txtobj = (from p in db.TB_TEXTO where p.TEXTO_ID == id.ToString() select p).FirstOrDefault();

            if (txtobj != null)
            {
                txt = txtobj.TEXTO.ToString();
            }

            return txt.ToString();
        }

        public void SaveText(string id, string texto)
        {
            //salva texto
            BlocoNotasEntities1 db = new BlocoNotasEntities1();

            //saber se já existe id
            TB_TEXTO txt = new TB_TEXTO();
            txt = (from p in db.TB_TEXTO where p.TEXTO_ID == id select p).FirstOrDefault();

            if (txt != null)
            {
                //saber se texto foi alterado
                if (texto != txt.TEXTO)
                {
                    //caso tenha sido alterado, gravar novo texto
                    txt.TEXTO = texto.ToString(); ;                                    
                    db.SaveChanges();
                }
            }
            else
            {
                //novo textoC:\Users\Denis\Documents\Visual Studio 2013\Projects\NotePadServer\NotePadServer\WcfService1\Service1.svc
                txt = new TB_TEXTO();

                txt.DATA = DateTime.Now;
                txt.TEXTO_PK= 0;
                txt.TEXTO_ID = id;
                txt.TEXTO = texto;

                db.TB_TEXTO.Add(txt);
                db.SaveChanges();
            }
        }
    }
}
