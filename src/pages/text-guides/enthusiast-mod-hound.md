[Mod Hound](https://app.ts4modhound.com/) is a website created by [Lumpinou](https://www.patreon.com/lumpinou).

For mod creators, it's a place where you can list your mods, including if they were updated, if they're broken or obsolete or working fine with the current patch, and if they require other mods that are also listed on the site; and where you can use various other tools that are useful when modding.

For players, it's a place where you can have the website scan your Mods folder (or your mc_lastexception, BE-ExceptionReport.html, or Lumpinou File Log File) for various things, like outdated or broken mods.

Mod Hound has collaborated with PlumbBuddy to incorporate these scans into the PlumbBuddy app. On the Mod Hound tab, you can request that PlumbBuddy send a list of your mods to Mod Hound, and Mod Hound will send back a report that you can view in the app.

***Note:*** Mod Hound will ONLY give you results about mods that are listed on Mod Hound. It has no knowledge about any mods not listed there. It can also only give you information if that information is listed by the creator.

---

### The Settings

Mod Hound settings can be accessed in the menu on the left of PlumbBuddy, with other PlumbBuddy settings, of from the Mod Hound tab, by clicking on the gear icon next to the Request New Report button.

![image](/img/modhound-gear.png "The Mod Hound dog in a circle at the left, a Fetch Report button, a gear icon, and a question mark in a circle to the right, and an empty Display Report box below that.")

---

*Report Retention Period:*

This setting tells PlumbBuddy how long you want your Mod Hound reports kept. You can refer back to them at any point as long as they still exist in PlumbBuddy's database.

You can go as low as two days or as high as twelve weeks using the sliding scale. At the left are two buttons: one to tell PlumbBuddy to keep your reports *forever* (or at least until PlumbBuddy gets uninstalled), and the other to go back to the default setting, which is four weeks.

---

*Packages Exclusions:*

This setting is to tell PlumbBuddy where your Custom Content is in your Mods folder, so that it won't try to send those files to Mod Hound.

***Mod Hound doesn't list CC, and it has a strict file limit for how many files it will scan.***

***File limits may change based on the needs of the Mod Hound website. The defaults are listed here.***

If you have over 5,000* files (.package and .ts4script) in your Mods folder, PlumbBuddy will warn you that you have a lot of files and you should consider excluding your CC. This is to prevent taxing the Mod Hound website, to keep it happy and healthy and available for everyone to use.

If you have over 26,000* files, PlumbBuddy will refuse to submit them, because Mod Hound will reject them. Again, Mod Hound is not designed to have any information on your CC, just on your mods.

In the settings, when you have over 5,000 files, the box next to the number of files at the bottom left will change from green to a warning colour. If you have over 26,000 files, the box will turn to an error colour, giving a visual clue that you that you can't request a report until you remove some files or use an Exclusion above.

You can see the number of files that are being excluded in real time as you change your Exclusions.

There are two ways to add an exclusion:

1. Look for Leading Text in Package File Paths

The easiest and most reliable way to add an Exclusion is to type in the name of a folder inside your Mods folder in which you have CC (just CC, no mods) and end it with a forward slash (/), then hit enter. This will tell PlumbBuddy to ignore anything in that folder. Do not use a backslash (\).

* It must include the **full path** to that folder. If you have, for example, a folder called CAS, and inside that folder you have a folder called CC and a folder called Traits, you'd need to type in 'CAS/CC/' to exclude the CC but not the traits.

* You can choose to not type in each folder name if you have multiple that start the same way, but this may have unintended results. If you type in just CC and not 'CC-CAS/', in the image below, it would exclude all of the folders listed, but also potentially other things that you don't want to exclude.

2. Test Package File Paths with Regular Expressions

If you're familiar with Regex, this is for you.

This is for if you want to exclude a wide group of folders named in a similar way, but that don't *start* the same way, or if you want to exclude things that contain a specific term, or other things you can do with Regex. You can be both more precise and broader in your search. If you aren't sure how to use Regex, if you type in something that just won't work, you'll get a prompt asking if you want to be taken to a sandbox website so you can experiment.

![image](/img/modhound-settings-enth.png "The Mod Hound settings as described above, with three folders excluded, and at the bottom, a green symbol and 3033 Packages included on the left, and a grey symbol and 2534 Packages Excluded")

---

### Fetching a Report

When you want to have Mod Hound scan your Mods folder, you can click the Fetch Report button on the right on the Mod Hound tab.

If your Mod Health scans aren't complete yet, PlumbBuddy will pause before sending the request, because Mod Health tells the Mod Hound tab what files you have.

PlumbBuddy will keep you updated on your report's progress.

![image](/img/modhound-in-progress.png "The Mod Hound dog in a circle at the left with a blue bar being filled at the outside, and the words Your Request is Being Processed to the right above an empty Display Report box")

When your report is ready, there will be a notification in the top right.

![image](/img/modhound-ready.png "A green box saying 'Good news, your Mod Hound report is finished and ready to view!'")

Or you might get a notification that you've already requested a report on this exact same Mods folder (same files and same file dates) and nothing has changed on Mod Hound's end, and PlumbBuddy will bring that report up for you.

![image](/img/modhound-dupe.png "A green box saying 'Good news, I already asked Mod Hound about this exact configuration of your Mods folder about 44 seconds ago, and according to Mod Hound, nothing has changed since then. I've selected that report for you for your convenience.'")

If you want to view an existing report, you can select it from the drop down box.

![image](/img/modhound-pick-report.png "A selection menu with four dates/times to select in the foreground, with the Mod Hound logo and buttons faded in the background")

---

### Reading a Report

Once you have (or select) your report, everything might be all good, or you might have some results that you should work on. Click on a section of the report to see what it says.

![image](/img/modhound-report-menu.png "At the left is the Mod Hound logo. In the middle is the FEtch Report button and the Display Report selection box. To the right are 8 icons, each representing part of the report.")

Each report can be searched by file, mod, or creator name, by date, and by the update notes. You can clear your search by clicking the X in the search bar.

![image](/img/modhound-report-search.png "An image of an Up to Date report being searched for 'little'")

---

*Outdated:*

This is a list of mods that are in your Mods folder that you need to update, based on the date of the file in your Mods folder compared to the date of the file listed on Mod Hound.

It will give you the file name, the mod name, the creator, the file's date on Mod Hound, the file's date in your Mods folder, and any update notes that the creator set.

At the left, there are two buttons: one to show you the file in your Mods folder, and the second to take you to the download page listed for the mod. You should delete the old copy and add the updated version.

---

*Duplicates:*

This is a list of files that you have two or mods copies of, based on the file names.

It will give you the file name, the mod name, the creator, the file's date on Mod Hound, the file's date in your Mods folder, and any update notes that the creator set.

At the left, there are two buttons: one to show you the file in your Mods folder, and the second to take you to the download page listed for the mod. If one copy is older than the other, delete the older copy. Make sure to keep all files from a single mod together.

In the end, you should have only one copy of each mod.

---

*Broken/Obsolete:*

These are mods that the creator has listed as broken (they will *probably* be updated at some point, but you shouldn't have them in your Mods folder at this point) or obsolete (they no longer exist, or they no longer exist in their current form).

It will give you the file name, the mod name, the creator, the file's date on Mod Hound, the file's date in your Mods folder, and any update notes that the creator set.

At the left, there are two buttons: one to show you the file in your Mods folder, and the second to take you to the download page listed for the mod.

Pay close attention to the update notes. They may tell you what you need to do — if you need to delete it completely, or if there's a new version available. You can also check the download page to see if there's any information available there.

Either way, the broken or obsolete files you have should be deleted from your Mods folder.

---

*Incompatible:*

These are mods that you have in your Mods folder that the creator says cannot be used together.

They will be divided into sets, such as First Incompatibility and Second Incompatibility. Click on each one to see the files/mods. It will give you the names of each one. Click on the name to be taken to the file's location in your Mod folder.

These may be files from the same mod but are a 'pick one version' type of conflict. For example, maybe you're supposed to pick one uniform colour. These may be mods that conflict as a whole, and you need to pick one and delete the other. If both mods have other mods that require them, you may be able to use either, or some mods require a specific mod. In that case, you'd have to make a decision about which you would keep after checking the mod descriptions.

![image](/img/modhound-incomp.png "An image from an Incompatible report, with the First Incompatibility section open to show the names of the two incompatible mods")

---

*Missing Requirements:*

These are mods that are missing another mod that they need to work.

They will be divided into sets, such as First Missing Requirement and Second Missing Requirement. Click on each one to see the Mod Missing the Requirement and the Mods that Make Up the Requirement. It will give you the names of each one. Click on the name of the missing requirement to be taken to its download page.

If a mod creator listed something as required for their mod to work, then often not having it can lead to problems in game — from visual issues to errors to the game not loading — or to the mod not functioning at all.

Mod Hound can only give you this information if *both* the requiring mod and the required mod are listed on Mod Hound, and if the creator has listed the requirement.

---

*Unknown Status:*

These are mods that are listed on Mod Hound but that don’t have a current status listed by their creator.

It will give you the file name, the mod name, the creator, the file's date on Mod Hound, the file's date in your Mods folder, and any update notes that the creator set.

There isn't really any advice Mod Hound can give for these mods. You can check the download page to see if more information is given there. Otherwise, they have the same status as any untracked mod.

---

*Up to Date:*

These are mods that should be up to date according to their date of the file in your mods folder compared to the date listed on Mod Hound. They've been cleared for the patch that Mod Hound is currently tracking, and you have the most recent version listed.

It will list the file name, the mod name, the creator, the file's date on Mod Hound, the file's date in your Mods folder, and any update notes that the creator set.

There's nothing to do with this report. It's just there for your information.

---

*Not Tracked:*

These are mods (or custom content) that aren't listed on Mod Hound.

It will list the file name, file date, and file type (Package or Ts4Script).

There's nothing to do with this report. It's just there for your information.