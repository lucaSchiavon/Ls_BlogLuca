using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using AQuestBaseProject.Utils;

namespace AQuestBaseProject.Web.Helpers
{
	public static class UrlsHelper
	{
        public static string GetAboutUrl(string currentLangCode)
        {
            return "/" + currentLangCode.ToLower() + "/About";
        }
        public static string GetHomeUrl(string currentLangCode)
        {
            return "/" + currentLangCode.ToLower() + "/Home";
        }
        public static string GetContactUrl(string currentLangCode)
        {
            return "/" + currentLangCode.ToLower() + "/Contact";
        }
        //      public static string GetPostDetailUrl(this UrlHelper helper, string currentLangCode, string title, string id)
        //{
        //	return "/" + currentLangCode.ToLower() + "/post/" + title.ToUrl() + "/" + id;
        //}
        //public static string GetProductDetailUrl(this UrlHelper helper, string currentLangCode, string title, string id)
        //{
        //    return "/" + currentLangCode.ToLower() + "/product/" + title.ToUrl() + "/" + id;
        //}
        //public static string GetProductDetailUrl(this UrlHelper helper, string currentLangCode, string title, string id)
        //{
        //    return "/" + currentLangCode.ToLower() + "/" + title.ToUrl() + "/" + id;
        //}
        //public static string GetProductsUrl(this UrlHelper helper, string currentLangCode)
        //{
        //    return "/" + currentLangCode.ToLower() + "/product";
        //}
        //public static string GetConfezioneUrl(this UrlHelper helper, string currentLangCode, string title, string id, string idConfezione)
        //{
        //    return "/" + currentLangCode.ToLower() + "/confezioni/" + title.ToUrl() + "/" + id + "/" + idConfezione;
        //}
        //public static string GetConfezioniUrl(this UrlHelper helper, string currentLangCode, string title, string id)
        //{
        //    return "/" + currentLangCode.ToLower() + "/confezioni/" + title.ToUrl() + "/" + id;
        //}
        //public static string GetFornoUrl(this UrlHelper helper, string currentLangCode)
        //{
        //    return "/" + currentLangCode.ToLower() + "/forno";
        //}
        //public static string GetPrivacyUrl(this UrlHelper helper, string currentLangCode)
        //{
        //    return "/" + currentLangCode.ToLower() + "/privacy";
        //}
        //public static string GetFoodServiceUrl(this UrlHelper helper, string currentLangCode)
        //{
        //    return "/" + currentLangCode.ToLower() + "/foodservice";
        //}
        //public static string GetContattiUrl(this UrlHelper helper, string currentLangCode)
        //{
        //    return "/" + currentLangCode.ToLower() + "/contatti";
        //}
        //public static string GetFoodServiceDetailUrl(this UrlHelper helper, string currentLangCode, string ProductTitle, string idPrimaConfezione)
        //{
        //    return "/" + currentLangCode.ToLower() + "/foodservice/" + ProductTitle.ToUrl() + "/" + idPrimaConfezione;
        //}

        #region "URL delle immagini"
        //public static string GetProductImageUrl(string IdProdotto, string NomeImmagine)
        //{
        //    //es GetProductImageUrl(51, string product2)
        //    //@String.Concat("/Public/Gallery/items/", Model.CurrentProduct.IdProdotto, "/static/product2.png")
        //    string DirectoryPath = "/Public/Gallery/items/" + IdProdotto + "/static/";
        //    string PhisicalDirectoryPath = HttpContext.Current.Server.MapPath(DirectoryPath);
        //    System.IO.DirectoryInfo Di = new System.IO.DirectoryInfo(PhisicalDirectoryPath);

        //    string Estensione = "";
        //    if (Di.Exists)
        //    {
        //        System.IO.FileInfo[] ArrFi = Di.GetFiles();



        //        foreach (System.IO.FileInfo CurrFi in ArrFi)
        //        {
        //            if (NomeImmagine == CurrFi.Name.Split('.')[0])
        //            {
        //                Estensione = CurrFi.Extension;
        //            }
        //        }
        //        return DirectoryPath + NomeImmagine + Estensione;
        //    }
        //    else
        //    {
        //        //non è stata caricata immagine per il prodotto
        //        return "'#'";
        //    }


        //}

        //public static string GetAbsoluteProductImageUrl(string IdProdotto, string NomeImmagine)
        //{
        //    string RelativePath = GetProductImageUrl(IdProdotto, NomeImmagine);
        //    string Host = HttpContext.Current.Request.Url.Host;
        //    return "Http://" + Host + RelativePath;

        //}

        public static string GetSiteUrl()
        {
          
            string Host = HttpContext.Current.Request.Url.Host;
            return "Http://" + Host;

        }


        #endregion
    }
}