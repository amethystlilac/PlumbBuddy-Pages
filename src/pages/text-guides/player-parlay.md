### Translating a Mod with Parlay

So you’ve found a mod, and it doesn’t come in your language. Or it does, but it’s not the right version of your language–maybe it’s in Brazilian Portuguese and you’re from Portugal, or it uses American spelling instead of British. Maybe you want to see it in your language for personal use or to share with others.

Parlay’s here for you. Parlay is meant to be a user-friendly way to translate a mod from one language you understand into another. It generates a translation file next in your mods folder to the mod file you’ve chosen in a name format that will work for Windows players. (Sorry, Mac users, the usual translation difficulties prevent us from reliably naming a file for you. It might work as it is, or you may need to use your usual tricks to get it to work.)

You can find the Parlay tab at the top of your PlumbBuddy app.

![image](/img/parlay-tab.png "The tabs at the top of PlumbBuddy, with Parlay in a yellow box")

When you go to Parlay, the first thing you’ll see is a big empty bar and some greyed out buttons.

If you click on the bar, at first it will display all of the mod files in your Mods folder that have string tables, beginning with any that have PlumbBuddy manifests. Below those, all unmanifested mods are listed. If you start typing, you can search for the mod you’re looking for if you know its name or creator in PlumbBuddy’s Catalog, its file name, or the name of its folder in your mods folder. If the mod you want to translate isn't in the list, it's possible it doesn't have translatable strings.

![image](/img/parlay-search-mod.png "Searching for a mod in Parlay")

Find the mod you want to translate. Pick a file by clicking on it. If you pick the wrong one, or you’re finished with the one you picked, you can close it with the X on the right end of the bar. You can choose another file by clicking on the bar or the box at the right end of the bar. Once you select it, you'll have more options.

![image](/img/parlay-mod-picked.png "An image with a mod selected in Parlay. Along the top, there's a box that titled Package Containing String Tables with a file selected, a blue button with an icon of a person waving, a pink button with a piece of paper and a magnifying glass, a similar greyed out button, and a greyed out button with a table. Below those are a box that says Show Existing String Table, Translator, and Translate to Language.")

Next to the name of the file that you've chosen, if you've chosen a mod with a PlumbBuddy manifest, you may be able to see a message that the creator left for translators and/or a clickable link to take you to a place you can submit a translation if you choose to.

![image](/img/parlay-translators-note.png "An image with a written not to translators and a link")

Next, there’s a button to show the file you’ve selected in your mods folder.

Once you’ve started translating, there’s a button that will show you your translation file in your mods folder.

And last on the right is a button to merge the string table from your chosen language into your translation file, either from the original mod file or from an existing translation file. This is useful for updating an existing translation.

Below that is where the real work takes place.

### Translating the Mod

First on the left, you’ll need to pick the **original** language you want to translate from. It can be any string table in the original package, ideally one you understand. You can search or scroll to the language of your choice, as long as a string table for that language is included.

![image](/img/parlay-orig-lang.png "The beginning of the list of string tables in the chosen file")

Next to that, you enter your translator name. This is the name that will be listed in the PlumbBuddy manifest that will be created in your translation file, which will be shown in the Catalog, and which the mod creator can credit you with.

On the right is a list of the languages and dialects you can translate the mod into. There are a LOT of languages and dialects.

If you choose a language that does not officially exist in the game, if there’s a close equivalent (if you want to translate into Canadian French instead of France French), Parlay will use that near match to create its string table. If there’s no near match, Parlay will use the English string table.

Your file name will reflect the actual language/dialect you chose, and so will the manifest (and the Catalog).

If there’s a manifested translation made in Parlay with its original file name in your mods folder, Parlay will detect it and import any existing strings, and any edits will go into that file. File name is important because Parlay supports translating un-manifested mods. Other parts of PlumbBuddy rely solely on mod manifests, but Parlay can’t do that, so it needs the file name to be the same. If you have a translation from another source or one from Parlay that’s been renamed, or there’s a translation included in the mod itself, you can use the Merge Translation String Table button at the top right to import the strings.

![image](/img/parlay-new-lang.png "The beginning of the list of possible languages to for the translation")

If you choose to merge an existing translation into your translation file, the strings will appear in the blank boxes on the right. If you’re translating something that has, for example, all strings in English, it will just add the English strings on both the left and the right.

To begin translating, click in the right column next to the line you want to translate.

![image](/img/parlay-translating.png "An image of a translation in progress")

To confirm a translation and have it added to your translation file, you can use the checkmark at the right or navigate to another line by using Page Up/Page Down.

You can change lines by clicking into a different line or by using the Page Up/Page Down buttons on your Keyboard. You can switch between tokens by using Tab or Shift-Tab on your keyboard. These instructions are at the bottom of the screen.

To delete a string’s translation, you will need to delete the text of the translation and then confirm it with the box blank.

You can sort the strings multiple ways. Click the name of a column once to sort alphabetically (starting with special characters/1/A), twice to sort alphabetically in reverse (starting with Z), and three times to return to the default sorting (however it happens to be sorted in the package file, generally in order that the creator added the strings). This includes the translation column — if you sort in reverse alphabetical order, any empty boxes (the ones you haven’t translated) will come to the top.

You can also search strings, using the search box at the top right of the translation area. It will search all columns: Hash, Original, and Translation. It will only find exact matches (celeb won’t find célébrité), but it will find partial matches (céléb will find Enfant célébrité).

As you type, Parlay will offer you tokens you can use. Some of these are ones you just need to select. Some are ones that you need to fill in so that the game uses the appropriate word in its place. DO NOT translate the tokens that a creator used. Use them or their equivalent in your translation. If it says {0.SimFirstName}, it must not be translated to {0.SimPrénom}. If a creator used something like {M0.him}{F0.her}, you can change the text inside to the correct words in your language. DO NOT change any numbers. They tell the game what is being referred to (for example, {0.SimFirstName} meaning the name of sim you’re playing and not the sim they’re talking to). They must be the same as in the original strings. Changing something like {0.SimPronounObjective} to a male/female pair ({M0.for him}{F0.for her}) would be acceptable if your language does not accept the first option.

![image](/img/parlay-tokens.png "Parlay suggesting possible tokens")

You can also choose to copy the tokens and paste them into the correct place in your text, or type them out. It’s all up to you.

### What’s Next?

Once you’ve completed your translation, you can use the button at the top right to see your translation file in your mods folder. You can use it yourself, share it, or send it to the mod creator. The little person button may have information on how the mod creator would like you to tell them about the translation.

![image](/img/parlay-find-file.png "An image pointing out the button to use to find your translation file")

By default, the file will be named something like `!amethyst_Family Reward Trait.fr-FR.l10n.package`. 

This is:

* ! to make the file load before the mod
* The original file’s name
* The code for the language you translated the mod into
* `l10n`, which is an abbreviation for localization (or translation)

Essentially: `!Mod Name.language-location.translation.package`


![image](/img/parlay-translation-file.png "The translation file next to the original package file")

This file will show in your Catalog. If you look at it, it will list you as the translator.

![image](/img/parlay-transl-catalog.png "The translation in PlumbBuddy's Catalog")

If the original mod is manifested, it will list that mod as a requirement for your translation, since a translation doesn’t do much on its own, and it will list your translation as a Dependent of the original. If you send it to the mod creator and they include it using Parlay, you'll be credited in the mod's Catalog description.

![image](/img/parlay-transl-dep.png "The original mod listing the translation as a dependent")

If you want to upload the file to share it with others, you may want to rename it. For example, I might want to rename  `!LittleMsSam_BetterNanny.fr-FR.l10n.package` to `!LittleMsSam_BetterNanny.traduction FR-amethyst.package`, if I decided to upload a translation. That would not affect how it shows up in PlumbBuddy’s Catalog for other players, and it would show that I was the one to make that file. If you’re sharing with others, you might also want to fill out the rest of the manifest. Or not, up to you. As long as you entered your name as the translator, you’ll still be credited in the manifest. Note that Parlay does not create a scaffolding file, so a warning about that is to be expected.