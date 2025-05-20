---

Once you have PlumbBuddy set up, you're ready to manifest a mod. Start by going to the Manifest Editor tab.

Manifests have many things that you can include. Most mods won't need many of them, but they're there if you do.

Most of this page is dedicated to manifesting a mod. Towards the bottom, there are sections on Updating a Manifest and Providing Support for Your Mods.

![image](/img/ME-tab.png)

---

### Select

![image](/img/ME-Select-tab.png "The Select tab of Manifest Editor, as described below")

On this tab, you will pick a file from your mod. It can be any file, a script or a package. PlumbBuddy does not accept any other file type.

You can use the file browser to find the file, use the Catalog to select a file that you already have manifested and is in your mods folder, or drag and drop the file. 

![image](/img/ME-file-pickers.png "Three buttons: one to Browse for a file, one to pick a file from Catalog, and one to drag and drop files")

If at any point during the process of manifesting your mod you decide to cancel and start over, you can go back to this tab by clicking its symbol at the top, or click Cancel in the bottom left.

![image](/img/cancel.png "Cancel")

Before you pick a file, look below the file selection bar.

There’s a toggle here for where PlumbBuddy will look for a scaffolding file (a .yml file), which is created at the end of manifesting. When that happens, you can choose to have PlumbBuddy put that file with the mod file you’re manifesting OR in a subfolder called PlumbBuddy. If you’re re-manifesting a mod, PlumbBuddy will look both with the mod file and for a folder called PlumbBuddy. It’s on by default, meaning PlumbBuddy will look for a PlumbBuddy folder first. It will find the scaffolding either way, whether it’s with the file or in a PlumbBuddy subfolder, but this will tell it where to look first.

![image](/img/scaffloding-toggle.png "A toggle in the on position and the text 'Check for scaffolding in a PlumbBuddy subfolder first.'")

Note that this button connects to another button at the end of the manifesting process. If you have it on here, PlumbBuddy will assume you want it to put its scaffolding files in a PlumbBuddy folder for you. At the end, when you finalize, unless you turn it off again, PlumbBuddy will create that folder if it doesn’t exist. If you turn it off and that folder exists, PlumbBuddy will move any scaffolding files out of that folder to exist alongside the file they represent, and if the PlumbBuddy is empty, it will delete the folder.

While you can’t come back to this tab without starting over, you can change your choice about where scaffolding files will go on the final tab.

Underneath that toggle, there’s a button for bulk updating manifests. There will be more on that in the Updating a Manifest section.

![image](/img/manifest-bulk-update.png "Update All the Manifests in Mods in a Folder")

On the bottom left, there's a toggle to have PlumbBuddy give you a list of packs for use in your manifest. It defaults to off. To turn it on requires an internet connection. If it is on, instead of saying that your mod/files requires EP01, you get a drop-down list. This toggle is available on all tabs, and can be turned on and off as you wish.

![image](/img/pack-codes-toggle.png "A toggle in the off position and the text 'Use PlumbBuddy.app Public Pack Catalog when entering Pack Codes'")

Click Browse and navigate to one of the files from your mod. Then click Next on the bottom right or click the Details tab at the top to go to that tab.

![image](/img/next.png "Next")

---

### Details

![image](/img/ME-Details-tab.png "The Details tab of Manifest Editor, as described below")

If you’re re-manifesting a mod, and have the scaffolding file, it will remember a lot of things about your mod. If you don’t have the scaffolding file, it will still remember a lot of things about your mod, but you’ll need to add back any additional files other than the one you picked on the Select tab.

If this is a new manifest, the Details tab is where you enter:

* The name of your mod. Just type/paste it in.
    * If for some reason you want to manifest files separately, but have them appear under the same name in the Catalog, use the same name for them.
    * If you want to manifest them together but have them show under different names in the Catalog, give them different names on the Components tab.
    ![image](/img/ME-mod-name.png "The name field for a mod, with 'What's your mod called? Pretty simple.' written below")
* A short description of your mod.
    * Plain text only. Formatting is not supported.
    * A player’s Catalog will display two lines. If your description goes longer than that, a scroll bar will appear.
    ![image](/img/ME-mod-desc.png "The description field for a mod, with 'What does your mod do? What's it for? Probably best to keep this short, but sweet.' written below")
* Your creator name, along with any other creators. Type your name in and press enter.
    * If you forget to press enter and there’s only ONE creator, PlumbBuddy will accept that as the creator. If there are two or more creators, PlumbBuddy will ignore any name that was typed without hitting enter.
    * If you chose to have one or more default creator names, they will be auto filled in, and you can add or remove names as needed.
    ![image](/img/MC-creator.png "The creator name filed for a mod, with the creator's name in a bubble above the words 'Enter a creator name here and press enter,' with 'So uhh... 🕵️‍♂️ who's responsible for this?' below")
* Where players can go to download the mod. Type/paste it in.
    * At the right end of this bar, there are three symbols. Click on the first to open the URL you entered. Click on the other two to see some advice for picking your Download Page URL.
    * If you are a creator who doesn’t have a stable link for a mod download, you can ask for a redirect link by clicking the link in the advice in the manifest editor, by coming to the [PlumbBuddy discord server](https://discord.gg/XKbMEEfRde), or you can [create a pull request on Github](https://plumbbuddy.app/community-services/redirect-hosting).
    ![image](/img/ME-URL.png "The Download Page URL field for a mod, with the words 'This should be a web page on which links or buttons are available to download the mod files for THIS MOD.' below, and three buttons on the right: a blue globe, a single hand held up in orange, and two hands clapping in green")

If you click Previous or Cancel at the bottom left, you’ll get a pop up asking if you’re sure you want to cancel. You can click Next on the bottom right or click a tab at the top to go to that tab.

![image](/img/previous-cancel.png "Two buttons: Previous and Cancel")

---

### Components

![image](/img/ME-components-tab.png "The Components tab of Manifest Editor, as described below")

On the Components tab, you add any other files that make up your mod, and you give some details about the individual files.

To add more files, click the button with the plus on it below the file list (green in the default theme) and navigate to the files, or the eyedropper button to drag and drop the files or folders. You can pick files in subfolders or with the main file chosen, or any other location on your computer if that’s where they are.

![image](/img/ME-components-file-select.png "Two green buttons with white symbols, one with a piece of paper and the other with an eyedropper")

To remove files, click the button with the X on it, orange in the default theme. Then select each file you want to remove, click the orange button again, and then confirm that you want to remove them.

![image](/img/ME-components-file-remove.png "An orange button with a piece of paper and an X")

You can also duplicate settings from one file to one or more others. With a file selected, click the duplicate button under the file’s settings, select the files you want to duplicate the current file’s settings to, and then click the duplicate button again. This will duplicate everything except the Component Name, the Manifest Snippet Tuning Resource Name, and the Subsumed Hashes.

![image](/img/me-components-dupe.png "A green button with two pieces of paper, one in front of the other, and an arrow going from one to the other")

Click on one of the files. There are many things you can say about that file.

The first thing shown is the current file path for the file. That can’t be changed, because it’s where the file is, but if you picked a wrong file, you can remove the file and add the correct one.

![image](/img/ME-components-file-path.png "The Local Path field for a file, with file selection buttons greyed out")

Next is a toggle for if this specific file is required for your mod to function. If it’s not, some of the other things are not applicable. It defaults to on.

![image](/img/ME-components-req-file.png "A toggle in the on position, with the words 'My mod requires this file to work properly — it is not an optional add-on to suit the player's preferences.'")

Below that is the Requirement Identifier (for required files only). This is used to tell PlumbBuddy that your mod requires at least one of the files with this identifier. This is ONLY for your currently loaded mod. You can have 5 mods with the same Requirement Identifier, and each mod will require at least one file from that mod with that identifier. PlumbBuddy won’t care that Universal Vacuums Mod needs at least one Requirement Identifier ‘purple’ when it’s looking at Universal Brooms Mod. Also note that Requirement Identifiers require at least one, not exactly one — exactly one comes later.

![image](/img/ME-components-req-identifier.png "The Requirement Identifier field for a mod, with the words 'If set, the player must have at least one file using this requirement identifier. Requirement Identifiers are scoped only to your mod. You don't need to worry about making them globally unique.' below")

Next is a set of four ‘Ignore’ boxes (for required files only). 

Universal Brooms’s file Hair Piles is required, but ignore that if the player ***has*** Cats and Dogs. Gnarled Wood Broom is required, but ignore that if the player ***doesn’t have*** Realm of Magic. Green Broom Override is required, but ignore that if the player ***also has*** your separate mod Blue Broom Override. Vacuum Compatibility file is required, but ignore that if the player ***doesn’t have*** Universal Vacuums. 

These can be combined in any way you need. Make sure they’re compatible–you CAN say to ignore if the player has GP01 and to ignore if they don’t have GP01, but please don’t. 

Note that to use Ignore If Hash Available/Unavailable, the file being referenced must already have a manifest and cannot be part of the current mod.

For packs, type in the pack code (ex. EP01) and hit enter, or use PlumbBuddy’s menu to pick a pack. If you choose to type the pack code, it must be two capital letters for the pack type followed by the two-digit number. You can only enter one item per ignore inside the Manifest Editor.

![image](/img/ME-components-ignores.png "Four boxes: The one on the top left is for Ignore if Pack Available and had the words 'Instructs agents to ignore this requirement if an official The Sims 4 pack from Electronic Arts has been installed by the player.' The top right box is for Ignore if Pack Unavailable and has the words 'Instructs agents to ignore this requirement if an official The Sims 4 pack from Electronic Arts has been installed by the player.' The middle box is for Ignore if Hash Available and has the words 'Instructs agents to ignore this requirement if the presence of a mod manifest hash in the load order indicates the player has installed another mod.' The bottom box is for Ignore if Hash Unavailable and has the words 'Instructs agents to ignore this requirement if the absence of a mod manifest hash in the load order indicates the player has not installed another mod.'")

Then there’s Exclusivities (for all files).

This is for when a player may have one and ONLY one.

You can pair this with Requirement Identifiers or use it alone to create a ‘pick one’ scenario.

This is for the player’s entire mods folder. You can get together with one or more modders and decide that you’re going to call venue lists Venue Lists, and if PlumbBuddy sees two or more in a player’s mods folder, it will warn them. You can also say Universal Brooms has a green broom override and a blue broom override, and the player may only have one–and if they’re not also required files, the player may choose to have none.

*Warning*: if you say the player must have all files, and then add exclusivity to two or more, you must find a way to make them also not required. For example, using a requirement identifier (the player must have at least one), or saying they must have these files but ignore if they have specific packs, or making them a separate mod and using Ignores (the player must have file A, but ignore if file B is present). If you don’t, you’re creating an impossible situation–both must be present, but only one may be present.

![image](/img/ME-components-exclusivities.png "The Exclusivities field for a file, with an exclusivity in a coloured bubble above the words 'Type the name of an exclusivity here and press enter' and the words 'Only one file with the same exclusivity will be permitted. If PlumbBuddy discovers multiple manifests in the same Mods folder with the same exclusivity, this will generate a warning for the player. Use this to mark mod files that are incompatible with each other, such as when they needed to select one package or another depending on whether they have a pack or another mod installed.' below.")

Next is a Message to Translators. You can say whatever you want, such as how to submit a translation to include or that you don’t include translations.

![image](/img/ME-components-msg-transl.png "The Message to Translators field for a file, with the words 'If translators use a manifest-aware tool like Parlay to translate string tables in this component, is there anything you'd like to say to them?' below")

That’s followed by a place to enter a Translation Submission URL. You can reference that in your Message. It can be a website, a form, a link to your discord server, whatever works for you.

![image](/img/ME-components-url-transl.png "The Translation Submission URL filed for a file, with the words 'If a translator would like to submit a translation to you to consider integrating into your mod, where should they go? (Hint: This could be a Discord join link.)' below")

And then a button to integrate a translation. While translations can be made in the Parlay tab of PlumbBuddy, that's not necessary for integration. Read more about integrating translations and crediting translators [here](https://plumbbuddy.app/text-guides/creator-parlay).

![image](/img/parlay-integrate-button.png "Integrate Translator's Override Package...")

Below that is Component Name. Available for all files, and optional. 

This will give the file its own name. It will show up in the player’s Catalog as a separate item. If you don’t include the name of the mod the file is part of, it could get confusing. (Universal Brooms Green Broom Override vs Green Broom)

![image](/img/ME-components-name.png "The Component Name field for a file, with the words 'Since each file in your mod will have its own manifest resource, it can technically have a different name if you want it to. This can be good for specifically labeling add-ons. It would probably be smart, however, to still include the full name of your mod, e.g. Vacuum Clean the Cats: Discover University Support.' below")

Then we have the Manifest Snippet Tuning Resource Name (package files only).

This is the name that will show up if you look inside the package file itself.

PlumbBuddy will generate it randomly to be something like llamalogic:manifest_1c9e775f377d457d9bba839a0f584587, but you can rename it if you like. It must be unique, the same as any tuning file.

![image](/img/ME-component-snippet-name.png "The Manifest Snippet Tuning Resource Name field for a file, with the words 'This component of your mod is a package file, so its manifest will be will be a snippet tuning resource in your package. This is the name of that resource and it should be unique. I will generate the full instance for the snippet tuning resource on my own using the Sims 4 modding community standard implementation of the 64-bit Fowler–Noll–Vo hash function with the highest-order bit set. You can change it if you are feeling brave, but make it unique.' below.")

Finally, Subsumed Hashes (all files). 

If your mod is a requirement of another mod, this hash will tell that other mod that the new version works even though it was made using an older version.

Example: you make a shared library for your mods. You make it a requirement of your other mods. You update your shared library to have more options. It still works for your other mods, even if they haven’t been updated too. The old version’s hash gets subsumed–the new version stands in for the old version when it’s found in a player’s mods folder.

This should be cleared only if your newly updated requirement mod (your shared library) will break mods that require an older version. Most of the time, this should be left alone to let PlumbBuddy do its thing.

![image](/img/ME-component-subsumed.png "The Subsumed Hashes field for a file, with the words These are the hashes of previous version of this mod file. The manifest keeps them so that if I'm checking to see if a player has your mod installed because another mod requires it, the other mod requiring an older version of your mod is not a problem. However, if you make breaking changes in this mod file you should probably clear these out so that it will be obvious that your newer version isn't going to work well with the other mod. Otherwise, it's best to leave this field alone and let me manage it for you.' below")

The Add Subsumed Hash From Mod Files should also mostly be left alone. Using it is telling PlumbBuddy that the file you’re working on is a replacement for the file you select there and will work for all mods that require the other file.

![image](/img/ME-component-subsumed-warn.png "A warning from PlumbBuddy about adding a subsumed hash: 'Tread lightly here 🤚: What you're about to do is tell me that this mod file counts for the one you're about to select in the file picker. Be sure you understand the ramifications of that before you do it.'")

When you’ve added all the details for each file, click Next on the bottom right or click a tab at the top to go to that tab.

![image](/img/next.png "Next")

---

### Requirements

![image](/img/ME-requirements-tab.png "The Requirements tab of Manifest Editor as described below, with PlumbBuddy's pack search toggle on")

The Requirements tab is where you say what your whole mods needs and any packs it’s incompatible with.

The first box is for packs your mod needs. Type in the pack code (ex. EP01) and hit enter, or use PlumbBuddy’s menu to pick one or more packs.

If you choose to type the pack code, it must be two capital letters for the pack type followed by the two-digit number, and if you have more than one, you have to hit enter or PlumbBuddy will not register it.

To check if the code you typed in is valid, turn on PlumbBuddy’s pack toggle — if it converts the pack to the full name, it’s valid.

![image](/img/ME-req-packs.png "The Required Packs field for a mod, with the words Does your mod need any official The Sims 4 packs from Electronic Arts to work?' below")

The EA Promo Code is for is you have a creator code.

If a player installs your mod but doesn’t have the required pack, they will be offered the choice of buying the pack and will be reminded to use your creator code if they choose to.

![image](/img/ME-req-promo.png "The EA Promo Code field for a mod, with the words 'If you have been invited to the EA Creator Network, PlumbBuddy can give players your Promo Code to use at check-out when buying packs to use with your mod.' below")

Incompatible packs is for when your mod does not work when a certain pack is installed.

![image](/img/ME-req-incomp.png "The Incompatible Packs field for a mod, with the words 'Are there any official The Sims 4 packs from Electronic Arts that will cause your mod to NOT WORK?' below.")

Below that, you can add a required mod, assuming it has a manifest.

Once you select that mod, you can click on the name to see the details of its manifest, and if applicable, to select features of that mod that your mod uses, and to add Requirement Identifiers — maybe your mod needs any of a variety of mods to work, but the player only needs to have one of them (you’d make them all required, and then add a Requirement Identifier, such as Venue List) — or Ignores — for if the player only needs this extra mod in certain situations (add a required mod and then tell it to ignore that requirement if you have a certain pack, for example). You can also add missing info if the original creator didn’t, such as a name or a download site.

To remove a required mod, click on the mod name, scroll to the bottom, and click Remove Requirement.

![image](/img/ME-req-mod.png "Add Required Mod...")

![image](/img/next.png "Next")

---

### Cross-Mod

![image](/img/ME-Cross-mod-tab.png "The Cross-Mod tab as described below")

This tab has two key features:

***Versions:***

Set the version of your mod.

![image](/img/ME-xmod-version.png "Two boxes. The one on the left is for Current Version and the one on the right is for New Version.")

This is toggled off by default unless PlumbBuddy detects a standardly formed version number (1.0 or 1.2.3) in one or more of your file names. In that case, it will be toggled on, and the detected version will be pre-filled in both the Current Version box and the New Version box.

If you don’t want PlumbBuddy to do anything with this, you can still toggle it off. If you want PlumbBuddy to track your version but it’s not detected, you can toggle it on.

*It’s important to use PlumbBuddy to this tab to change file names due to version changes.* If you change them manually, PlumbBuddy will not recognize the file and will think you have no scaffolding file. This will result in you having to add all files manually again.

If you don’t include the version in your file name, this is just internal tracking. Set it to what you want and continue.

If PlumbBuddy doesn’t detect your version, or if it does but it’s not correct, you can change it. For example, you use v1 (type in v1 or just 1), or you use v1.2.3.4 (replace 1.2.3 with v1.2.3.4 or 1.2.3.4) or banana (type in banana).

If you’re updating your version, change it in New Version and PlumbBuddy will change it in the file name ONLY if it’s already in the file name.

If you use a version in one file but not the rest, it will only change it where it already is. If you want to update Trait version apple to Trait version banana, apple would be in the Current Version and banana would be in the New Version, and PlumbBuddy will change the file name for you. Likewise, if you include something like the game version in your file name, you can change it here. Your version can be anything you want it to be.

***Features:***

If your mod is a requirement for other mods, you can list features that other mods may require. If your mod has a Tuning Injector and a Trait Tracker Injector, some mods may require one, some the other, and some both. You can specify which version of your mod contains which features, by adding and removing them here as you change versions.

![image](/img/ME-xmod-features.png "The Features box for a mod, with the words 'You can use this field to establish feature flags. When other creators reference your mod as a requirement, they will be able to specify which features they need. This can be seen as an alternative to version ranges.' below")

---

### Hashing

![image](/img/ME-hashing.png "The Hashing tab of Manifest Editor. There's a slider with three settings: Lenient, Moderate (Recommended), and Strict. Below on the right is a graphic indicating what the current hashing level hashes. Below on the left is blue text that says 'I identify your mod's files on players' computers by examining the contents of the files, not by trusting file names. This is because players can (and do) rename mod files to influence the game's mod load order. I need to know what things in your mod's files to consider in identifying your mod.' and orange text that says 'The inclination to increase this setting because the thought of players altering your mods upsets you is valid; but please do consider that some players may have a good reason for this, such as using your mod in a language for which you do not provide a translation, and arbitrary strictness here will punish them when that may not be your intention.'")

How comfortable are you with players altering your mod for their own personal use?

Here you set how lenient or strict you want to be.

Do you want the entire file hashed, so if anything at all changes in it, PlumbBuddy won’t recognize the file and be able to tell a player its requirements and restrictions–they changed something, now they’re on their own?

Are you okay with players altering images and strings, but nothing else?

Fine with them changing the tuning and SimData? It can’t get much more lenient than that, because PlumbBuddy does need something to hash so it can recognize the file.

PlumbBuddy will use your chosen settings here, assuming they’re possible (if a file is images only, PlumbBuddy will have to hash them, even if you choose Lenient), and use it to create an identifiable hash that will let PlumbBuddy recognize the file after it’s been renamed from Universal Brooms.package to Scope universali.package.

Hashing is used to let PlumbBuddy recognize your mod in a player’s mods folder. The player can rename it, and PlumbBuddy will still know it’s there, as long as they didn’t alter any of the things that PlumbBuddy hashed. PlumbBuddy will recognize it by the hash, and will use that information to give the player information about things like requirements and to list it in their catalogue.

It’s also used when you update, so that a mod that requires your mod will recognize the updated version without having to update their own mod.

---

### Confirm

![image](/img/ME-Confirm.png "The Confirm tab of Manifest Editor")

Last tab!

Here you get your chance to change that toggle you set way back on the Select tab. Maybe you’ve been thinking about it, and you don’t want 10 different scaffolding files loose with your mod files, increasing the risk they’ll end up in the zip you upload. Or maybe you don’t need another folder. If you forget what this is:

> There’s a toggle here for where PlumbBuddy will look for a scaffolding file (a .yml file), which is created at the end of manifesting. When that happens, you can choose to have PlumbBuddy put that file with the mod file you’re manifesting OR in a subfolder called PlumbBuddy. 

When you finalize, if this toggle is on, PlumbBuddy will create that folder if it doesn’t exist. If the toggle is off and that folder exists, PlumbBuddy will move any scaffolding files out of that folder to exist alongside the file they represent, and if the PlumbBuddy folder is empty, it will delete the folder.

Below that are any warnings for things you may have forgotten, like a mod name, a creator name, a download URL, or your creator code if you listed a required pack.

Once you’ve fixed any warnings, or decided to ignore them, you can click Finish to the bottom right, and you’re done!

![image](/img/ME-finish.png "Finish")

Your mod files have their manifests, and players who use PlumbBuddy can now see all the details you listed for it, and get warned if they try to install it incorrectly.

---

### Updating a Manifest

You’ve updated your mod. Maybe it’s patch day, or maybe you added or removed features or requirements, or there was a bug or a typo.

It’s important to update your manifest every time you update your mod. This ensures that PlumbBuddy can recognize your mod in a player’s Mods folder, and warn them about things like missing requirements, and puts it in their catalogue in PlumbBuddy.

***Method 1:***

If you made changes that should be reflected in the manifest (added a file, for example, or changed a requirement) or if you need to change the version in the file name, you’ll need to load the mod in the editor and change the things that need changing. If you have a version and it changed, make sure to update that too. When you’ve made all the changes you need to, you can go to the Confirm tab and click Finish.

If you don’t have the scaffolding file (the .yml) for any of your updated files, you’ll need to manually update the manifest, as described above.

If nothing substantial has changed, there are two ways you can go about it:

***Method 2:***

Load the mod in the editor, go straight to the Confirm tab, and click Finish. You’re done and ready to go. You can also go through all the tabs to make sure everything is exactly as you want it to be, and that nothing changed that you forgot about. This is the method that PlumbBuddy uses if you update a manifest from the ‘mismatched inscribed mod manifest hashes’ scan.

***Method 3:***

On the Select tab, click the Update All the Manifests in Mods in a Folder button. Select the folder that the mods that need their manifests updated are in. The files can be directly in your chosen folder or in a subfolder.

Make sure that there are no mods in this folder that need manual updating because of changes made to them.

Make sure that the mods that were updated have scaffolding in the folder.

PlumbBuddy will immediately scan all package and script files in your chosen folder for files that have had changes that require an updated manifest.

If there are any errors, the update will abort. You can stop the update at any point, and only files that have already completed will update. You will get a warning if there are any unresolved warnings on any of the files, and you can choose to ignore or cancel the update.

When the update is complete, a report will appear, listing all files that were updated, all files with manifests and scaffolding that did not require an update, and all files that were skipped because they had no scaffolding. If you click Yes at the bottom right, the list will be copied to your clipboard for you to paste wherever is convenient to you. If you click No, the report will close.

---

### Providing Support for Your Mods

If you’re a creator who provides support for your mods, and you’d like players to have the option to seek help or report bugs from within their Catalog, please let us know! You can come to the [PlumbBuddy discord server](https://discord.gg/XKbMEEfRde) or you can create a [pull request on Github](https://plumbbuddy.app/community-services/support-venues).

Your support avenue will only show up on mods with your creator name. It won’t show up for general support (unless you also opt in for that) or for error file support (unless you opt in for that in general, or unless you have a specific error file that you’d like to have players encouraged to report to you — SpecificMod_error.txt, for example).

This can be a discord server, a website, a reporting form, or anything else that can be reached through a URL. You can also provide instructions for how best to receive help.

You can also opt out of providing support for specific mods. For example, if you’re a collaborator for a mod, but it’s not really your mod, but they credited you in that mod’s manifest, you can opt in in general, but opt out on a per (manifested) mod basis.