using System.Configuration;

namespace tw.lib.Util
{
    public class ConfigurationUtil
    {

        public const string LoginFormId = "tvorbaWebu.LoginFormId";
        public const string AfterLoginFormId = "tvorbaWebu.AfterLoginFormId";
        public const string AfterPasswordResetFormId = "tvorbaWebu.AfterPasswordResetFormId";

        public const string TvorbaWebu_ThankYou_PageId = "tvorbaWebu_ThankYou_PageId";

        public static int GetPageId(string pageKey)
        {
            return int.Parse(ConfigurationManager.AppSettings[pageKey]);
        }

        public static string GetCfgValue(string cfgKey)
        {
            return ConfigurationManager.AppSettings[cfgKey];
        }
    }
}
