namespace PlumbBuddyPages.Pages.CommunityServices;

partial class AdoptionGuidance
{
    readonly IReadOnlyList<BreadcrumbItem> breadcrumbs =
    [
        new("PlumbBuddy.app", "/", icon: MaterialDesignIcons.Normal.Web),
        new("Community Services", "/community-services", icon: MaterialDesignIcons.Normal.Offer),
        new("Adoption Guidance", "/community-services/adoption-guidance", icon: MaterialDesignIcons.Normal.Handshake)
    ];
    readonly string bulletListMarkdown =
        """
        * Have you received permission from the original creator?
          * If you have, you're good to go!
        * Are you sure the mod is orphaned or up for adoption?
          * Did the creator move to a new platform, like from Tumblr to Patreon or Boosty?
          * Did they change the URL of their website?
          * Are they creating under a new name?
          * If it's a mod that rarely breaks, the creator might appear out of nowhere to update it and then vanish into obscurity again.
          * Or maybe they announced their retirement/hiatus.
          * I'm sorry to say that if a modder insists their mod isn't broken but you believe it is or that it needs an update even if not "broken," then it's not orphaned. Make sure to check the comments to see if they're responding to people.
        * Have you checked the original creator's TOU, if one exists?
          * Some people might not want their mods adopted, or they might be fine with their mod being updated as is but not with things being altered or added to.
          * Be especially cautious if you plan to alter its current function drastically, incorporate it into another mod, or greatly expand on or reduce its scope.
          * On the other hand, the original creator may have said they were fine with anyone editing their mods, which is always good to know.
        * If possible, have you tried to contact the original creator in multiple ways?
          * They may check one platform but not another, or they may have lost access to some accounts.
          * You can try direct messaging them, commenting directly on the original post(s) (preferably not as a reply to someone else's comment), or any other way that you feel is likely to reach them.
          * It's a good idea to check if they have a contact page.
          * Do you have any contacts in common with them? Maybe a mutual friend?
        * Have you given the original creator plenty of time to read your request, think about it, and respond? If they're retired or on hiatus, they might not check their messages often. No need to wait forever, but make sure to give them a little while.
        * Has the mod already been adopted by someone else, who is actively maintaining it? There's no need to duplicate efforts.
        * It's not seen as a good practice to paywall someone else's work, even if you updated it. Please consider that when uploading it.
        """;
}
