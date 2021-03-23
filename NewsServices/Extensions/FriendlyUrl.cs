
using NewsCore.Extensions;

namespace NewsServices
{
    public static class FriendlyUrl
    {
        public static string Slug(string title)
        {
            return FriendlyUrlHelper.GetFriendlyTitle(title);
        }
    }
}
