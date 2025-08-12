Archivist is a feature of PlumbBuddy that's designed to safely securely back up your saves while taking up as little space as possible wherever you choose to store the files.



---

### The Vocabulary

Archivist uses some special terms to describe what it's doing.

* **Chronicle** — *Your whole save file*

    A Chronicle is the entire history of a save file, as long as it was started on the same computer.

    If you download a save file, or if you get a new computer, it will show as a separate Chronicle. For technical reasons, there’s no way around that.

* **Snapshot** — *One specific time you hit save or save-as in game*

    A Snapshot is a single save within a Chronicle.

    This can be when you clicked save or save-as, or when MC Command Center auto saved.

    Archivist will save them all, as long as it’s archiving while the save files are in your saves folder.

* **Tags** — *Small bits of information that Archivist auto detects about a Snapshot*

    Archivist will tag each snapshot with the world, lot name, household name, and if it was saved Live (if Archivist was actively saving while you had the game open).

    Live Snapshots have a special feature. See below for information on that.

    Tags are searchable.

* **Notes** — *Things you write*

    Notes are things that you write about a specific Snapshot or about a whole Chronicle.

* **Thumbnail** — *The picture you see*

    The Thumbnail is the picture used for a Chronicle or Snapshot.

    They are the same in game and in Archivist.

* **Name** — *The Chronicle name*

    The name of a Chronicle in Archivist.
    
    They are searchable.

* **Game Name Override** — *The name in game*

    The name Archivist will override your save with in game.

    Archivist must be actively archiving for this to happen. It can't happen if you Archive with the game closed.

    They are searchable.

* **Label** — *The Snapshot name*

    The name of a Snapshot within a Chronicle.

    The Label is only visible in Archivist, not in game.

    They are searchable.

* **Restore** — *Bringing a Snapshot back to the top*

    Restoring a Snapshot makes a copy of the Snapshot in a new save slot in the game while keeping it within the same Chronicle in Archivist.

    The new save slot will be at the top of your saves list in game. If you open the game again, this will be the save that you open if you click Resume.

    It's the equivalent of doing a save-as in game.

* **Branch** — *Moving to a new Chronicle*

    Branching a Snapshot creates a whole new Chronicle starting from that Snapshot.

    In game, it's the equivalent of doing a save-as, with a new save slot appearing at the top of your saves list in game. If you open the game again, this will be the save that you open if you click Resume.

    But in Archivist, the new Branch will be separated from the original Chronicle, while maintaining its history.

* **Export** — *Making a copy of a Snapshot outside your saves folder*

    Exporting will create a new .save file of a Snapshot that you can save to anywhere.

---

### Turning on Archivist

The first time you look at Archivist, it will be blank. That’s because it’s toggled off by default. You get to decide if and when you want to archive your save files.

![image](/img/archivist-empty.png "An image of Archivist empty, with two toggles set to the off position, a faded folder icon, and a question mark in a circle on the left.")

There are two toggles and a folder icon on the top left. The first toggle turns on Archivist scanning its own database for *existing* Chronicles. This toggle needs to be on before you can turn on the second toggle or click the folder icon.

If you have existing backup files of your saves, ones you've saved outside your saves folder in the normal game format, you can click the folder icon to have Archivist scan your backup folder. Archivist will only scan the folder you pick, not subfolders. If you have backups of saves currently in your saves folder, you may want to do this first, starting with the oldest if you have multiple. Or not, up to you — Archivist will still know which is oldest, but your Snapshot numbers won’t be in order.

The question mark will bring you to this page.

When you’re ready to have Archivist scan your saves folder, turn on the second toggle. It will start scanning again. The second toggle turns on Archivist actively saving Chronicles and Snapshots. You can turn this on and forget it, and as long as PlumbBuddy is active on your computer — on Windows, PlumbBuddy runs in the background, but on Mac, you need to choose to turn PlumbBuddy on — your saves will be archived.

You can also choose to only turn this on when you want it on. In that case, there's no guarantee that every Snapshot will be saved, because the game only saves five versions of each save slot before some get overwritten, and Archivist can only archive the saves that are currently in your saves folder.

It's your choice when (or if) Archivist is active.

![image](/img/archivist-menu.png "An image of Archivist's menu with both toggles on, a bright folder icon, and various Chronicles listed below")

When it’s done, you’ll probably have Chronicles named things like My Saved Game 19. They will have the name the oldest Snapshot had in game, as of when the Chronicle was first archived.

---

### Chronicles

If you click on one of the Chronicles, you can see some information about it right away.

At the top, you’ll see the Name of the Chronicle. By default, this is the name shown in the game for the oldest Snapshot that was archived the first time the Chronicle was archived.

Below that, you’ll see the size of its Archive file. This isn’t the game’s save files, it’s what Archivist has saved, after compression. The ratio of compression (how much space is used by Archivist vs. how much space is used by the same number of files in your saves folder) improves the more Snapshots are saved in a Chronicle — the bigger the save, the more compression there is for the same number of files.

Then there’s how old the save is, as far as Archivist can tell. This is the date of the oldest existing Snapshot. Unfortunately, Archivist can’t tell you about Snapshots that have been lost or not Archived.

Next is the date of the most recent Snapshot.

The last part of the default header is how many Snapshots Archivist has stored for this Chronicle.

To the right, are three buttons. From top to bottom, they are:

1. ***Edit this Chronicle’s Details***.
2. ***Reapply Customization to Existing Saves***. This will apply the Chronicle's Details, set using the button above, to any Snapshots in your *saves folder* from this Chronicle — it will alter what you see in game for previous versions of this save.
3. ***Show this Chronicle’s Database***. This will show you Archivist’s file for this Chronicle. ***Please use with caution.*** If you delete this file, Archivist will not know this Chronicle ever existed. If you alter it somehow, Archivist will likely not know this Chronicle ever existed, and it may cause errors. These changes are permanent. We cannot help you reverse them.


![image](/img/archivist-base-header.png "An image of the header of a Chronicle in Archivist. At the top, it says Snapshots on the left with a search bar on the right. Below that, the Name 'My Saved Game 4,380' is centered. Under that are tags for file size, two date and times, and the number of Snapshots. At the right are three buttons arranged vertically below the search bar.")

If you click Edit this Chronicle’s Details (the pencil), you have new options.

* You can set the Name for the Chronicle, as seen in Archivist. In the image below, the Chronical will be called `Test Save for Archivist` *in Archivist*
* You can write Notes about the Chronicle.
* You can set a Game Name Override, which will set the name of all Snapshots in this Chronicle in game going forward. This save will be called `Annabel's Shenanigans` *in game*. Each time I click save, or each time MC Command Center creates and auto save, the name in game will be overwritten with that.
* You can pick an image to use as the Thumbnail for this Chronicle from your computer. Thumbnails set by the game are 180x120 pixels. The ideal dimensions for a thumbnail are multiples of 3 wide x 2 high, which will be scaled by the game. If you go too large, Archivist will scale the image down. If you go too far outside 3x2, your image will not fit neatly in the box in game, but should still work. You can also choose the thumbnail from any existing Snapshot to use for the Chronicle, but that will be shown below.

![image](/img/archivist-chronicle-details.png "An image of the Edit Details section of a Chronicle open. At the top is a warning that `Changes you make here take effect immediately, whether or not you've clicked the check.` Below that is a box titled Name with the name `Test Save for Archivist.` Under that is a box for Notes that says `Time to show off all the fun stuff Annabel can get up to.` Then there's a box titles Game Name Override, which says `Annabel's Shenanigans,` under which it says `I will set the save's game name to whatever you enter here, if you enter something, so that you can easily distinguish this chronicle's saves when loading in The Sims 4.` At the bottom is a box for Custom Thumbnail with a picture of a vault above a Browse button. At the top right is a search box, and below that are three buttons. The top button is the checkmark referenced in the warning.")

After you get this section how you want it, you can choose to apply the Game Name Override and Thumbnail to all Snapshots currently in your saves folder using the middle button on the right, or to just use it going forward.

![image](/img/archivist-vault-header.png "An image of the header of a Chronicle in Archivist. At the top, it says Snapshots on the left with a search bar on the right. Below that, the Name 'Test Save for Archivist' is centered. Under that are tags for file size, two date and times, and the number of Snapshots. Under the tags, there's a horizontal line above the text `Time to show off all the fun stuff Annabel can get up to.` On the left is an image of a vault. At the right are three buttons arranged vertically below the search bar.")

Below all of that is a list of your Snapshots from that Chronicle.

---

### Snapshots

Below the header, you can see the date of each Snapshot, its Snapshot number, its tags, and three buttons.

![image](/img/archivist-list-snapshots.png "An image showing a Chronicle selected, with a list of Snapshots below. Each Snapshot has a date; a snapshot number; tags for Live, the household name, the name of the lot, and the world; and three buttons.")

At the left of each Snapshot is an arrow that you can click to view the details of each Snapshot. There you can see the Snapshot’s thumbnail when it was saved. You get the choice to use it for the entire Chronicle.

![image](/img/archivist-base-chronicle.png "An image of a Snapshot's details. At the top is the date, Label, and tags, with three buttons at the end. Below that is a picture of a sim on the left, the Snapshot's Label, two buttons for Use Thumbnail for Chronicle and Export Mod List, with three buttons to the right.")

The first button, after the tags, lets you Restore this Snapshot. It brings it to the top of your Load Save menu in game and puts it in a new slot in your saves folder.

The second button lets you Branch. It creates a new Chronicle within Archivist, in a new save slot in your saves folder, and at the top of your Load Save menu in game. It retains its connection to the original Chronicle, but you can never merge those two saves again. It is a new save. You can navigate back to the original Chronicle or Snapshot it was from using the links in the header of the Branched Chronicle.

![image](/img/archivist-branched-header.png "An image of a Chronicle's header with a link at the bottom leading back to the Snapshot it branched from.")

The third button lets you Export the Snapshot. This could be useful if you upload save files for other players, or if you’re sharing your save with someone for troubleshooting purposes. It’s important to note that the Exported file is not named to go in someone’s saves folder. It will be something like `Decades 1900s - Samuels - Snapshot 1.save`. This is to prevent overwriting someone’s existing save file with yours. To be read by the game, it needs to be renamed following the game’s save file naming conventions.

Below those three buttons when looking at an individual Snapshot, there are three more buttons. From the top:

* ***Edit this Snapshot’s Details***. You can change the label (from Snapshot 15 to The cat ran away) and add Notes.
* ***Try to Find this Save in the Saves Folder***. This will attempt to locate the file that corresponds to this Snapshot in your saves folder, even if it’s been renamed by the game. If it’s no longer in your saves folder, you’ll get a message telling you that. *Important note*: if you choose to delete a file from your saves folder, there must always be a file with that number ending with .save if you want the game to read it. The game does not acknowledge that `Slot_00000006.save.ver0` exists if there isn’t also `Slot_00000006.save`.
* ***Permanently Delete all Snapshots Preceding this one and Reclaim Space***. This will delete all Snapshots that can be deleted prior to the selected one. Snapshots can only be deleted starting at the beginning. You can’t delete from the middle or the end. You also can’t delete Snapshots if they’re in your saves folder. You have to delete the save files from there first. This is permanent. If you don’t have backups, the Snapshots will be lost. We cannot help you get them back once you delete them.

---

### Live Snapshots and Mods

Ever wonder what mods and CC you were using in a certain save? Did you accidentally delete your mods folder and not have any idea what you had? For Live Snapshots, Archivist can tell you. Click the Export Mod List, and Archivist will export a list of everything you had in your mods folder when that Snapshot was made.

A reminder: Live is when Archivist is actively archiving while the game is open. If you choose to have Archivist work while the game is closed, anything recorded then will NOT have this feature available.

---

### Searching

Once you have your saves archived into Chronicles filled with Snapshots, you can search them.

You can search Chronicles, at the top, and it will bring up all Chronicles with your search term anywhere in any Name, Label, Tag, Note, or date.

You can also search within a Chronicle, and it will bring up any Snapshot with your search term.

![image](/img/archivist-search.png "An image of Archivist being searched for `deca` with two Chronicles showing, both starting with Decades, and a Chronicle's Snapshots being searched for 'vero' with one result, which has the note `Veronica is now the nanny.`")