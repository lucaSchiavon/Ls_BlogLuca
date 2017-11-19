
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LS_BlogLuca.EF;

namespace AQuestBaseProject.Utils.Utils
{
    public static class TranslationUtils
    {
        //public static string GetLabel(string set, string key, string defaultValue, Dictionary<string, List<ResLabel>> labelsList = null,
        //	ContentEditorProvider.Configuration.EditorTypeEnum textMode = ContentEditorProvider.Configuration.EditorTypeEnum.Text, bool autoAddLabel = true)
        //{
        //	if (string.IsNullOrEmpty(set))
        //		throw new ArgumentException("empty resourceSet");

        //	if (string.IsNullOrEmpty(key))
        //		throw new ArgumentException("empty resourceId");

        //	if (labelsList == null)
        //		labelsList = new Dictionary<string, List<ResLabel>>();

        //	if (!labelsList.ContainsKey(set))
        //		labelsList.Add(set, LabelsProvider.GetLabelsByResourceSet(set));

        //	string retValue = LabelsProvider.GetLocalizedLabelFromList(set, labelsList[set], key, defaultValue, textMode, "", autoAddLabel);
        //	retValue = String.IsNullOrEmpty(retValue) ? defaultValue : retValue;
        //	retValue = WebUtility.HtmlDecode(retValue);

        //	return retValue;
        //}

        //public static string GetLabel(string set, string key, string defaultValue)
        //{
        //    if (string.IsNullOrEmpty(set))
        //        throw new ArgumentException("empty resourceSet");

        //    if (string.IsNullOrEmpty(key))
        //        throw new ArgumentException("empty resourceId");

        //    //se l'etichetta non c'è la aggiunge mentre se c'è recupera in base a lingua la traduzione

        //    ModelLucaBlog Db = new ModelLucaBlog();
        //    var etichette = Db.EtichetteIn

        //    //if (labelsList == null)
        //    //    labelsList = new Dictionary<string, List<ResLabel>>();

        //    //if (!labelsList.ContainsKey(set))
        //    //    labelsList.Add(set, LabelsProvider.GetLabelsByResourceSet(set));

        //    //string retValue = LabelsProvider.GetLocalizedLabelFromList(set, labelsList[set], key, defaultValue, textMode, "", autoAddLabel);
        //    //retValue = String.IsNullOrEmpty(retValue) ? defaultValue : retValue;
        //    //retValue = WebUtility.HtmlDecode(retValue);

        //    return retValue;
        //}
        public static string GetLabel(string set, string key, string defaultValue,string CurrentLangCode)
        {
            ModelLucaBlog Db = new ModelLucaBlog();
            string ContenutoEtichetta = "";

            if (string.IsNullOrEmpty(set))
                throw new ArgumentException("empty resourceSet");

            if (string.IsNullOrEmpty(key))
                throw new ArgumentException("empty resourceId");

            Etichette ObjEtichetta = Db.Etichette.Where(x => x.Gruppo == set && x.Chiave==key).FirstOrDefault();
            
            if (ObjEtichetta == null)
            {
                Etichette ObjNewEtichetta = new Etichette();
                ObjNewEtichetta.Gruppo = set;
                ObjNewEtichetta.Chiave = key;
                ObjNewEtichetta.Valore = defaultValue;
                Db.Etichette.Add(ObjNewEtichetta);
                Db.SaveChanges();
                ContenutoEtichetta = ObjNewEtichetta.Valore;

            }
            else
            {
                if (CurrentLangCode == "it")
                {
                    ContenutoEtichetta = ObjEtichetta.Valore;
                }
                else
                {
                    ContenutoEtichetta = ObjEtichetta.Valore_en;
                }
        
               
            }

            return ContenutoEtichetta;
        }
    }
}
