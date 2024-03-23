using tw.lib.Models.UmbracoCmsContent;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace tw.lib.Repositories.UmbracoCmsContent
{
    public class TextyRepository : _BaseRepository
    {
        public const int TextyId = 1064;

        public static Texty GetFromUmbraco(UmbracoHelper umbraco)
        {
            IPublishedContent content = umbraco.Content(TextyId);

            return content == null ? null : new Texty(content);
        }
    }
}
