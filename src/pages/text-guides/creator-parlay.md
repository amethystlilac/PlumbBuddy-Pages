For Information about translating a mod with Parlay, please visit the [Parlay guide for translators](https://plumbbuddy.app/text-guides/player-parlay).

---

### Messages to Translators

When you're manifesting a mod, you have an option to leave a message for translators. It's on the Components Tab, and you can leave a message in text, a link to where you'd like them to submit the translation, or both.

When a translator creates a translation using Parlay, they can view this message and click your link.

![image](/img/parlay-translators-note.png "An image with a written not to translators and a link")

---

### Integration

Once you have a translation (or have made one yourself) that you want to incorporate into your mod, you also do that in Manifest Editor, on the Components Tab.

First you select your mod (not the translation).

![image](/img/PB-Parlay-select-file.png "A mod file being chosen in Windows File Explorer, with Manifest Editor open in the background")

On the Components tab, select the file with your string table(s) on the right, and on the right, scroll down to the button that says `Integrate Translator's Override Package...`

![image](/img/parlay-integrate-button.png "Integrate Translator's Override Package...")

Click the button, and choose the translation you want to integrate.

![image](/img/PB-Parlay-select-transl.png "A translation file being chosen in Windows File Explorer, with a green button with the text `Integrate Translator's Override Package...` visible below")

If you already have a matching string table in the language of the translation, you'll be warned that you're going to overwrite that string table. Chances are, that's what you want, but PlumbBuddy will check with you, just in case.

![image](/img/PB-Parlay-warn-overwrite.png "A warning from PlumbBuddy that 'I'm About to Overwrite 220557da:80000000:070000000e57ddea in amethyst-Continuing Education Main File.package'")

If something's structurally odd about the translation, then you'll be warned again. In this case, not all strings were translated. Some were left empty.

![image](/img/PB-Parlay-warn-strings.png "A warning from PlumbBuddy that 'This French (France) Translation May Be Incomplete'")

If the translation was created for a language that's not one of the eighteen that comes with the game, but is *close* (say, Canadian French instead of France French), then it will use the string table that's 'close enough.' If it's something completely different (Thai, for example), you won't be able to merge.

![image](/img/PB-Parlay-warn-lang.png "A warning from PlumbBuddy that 'Maxis Non-Standard Languages Found'")

Once you've selected a translation that's valid for integrating, if the file was made in Parlay, and if the translator entered it, their name will automatically appear as a credited translator.

![image](/img/PB-translator-credited.png "An image of a translator's name in Manifest Editor with a French flag, above the `Integrate Translator's Override Package...` button")

Once you've done that, unless you need to make more edits to the manifest, you can go to the Confirm tab and finalize the manifest.

If you want to check that it all went well, you can look at the Catalog tab and see that the translation is listed and the translator is credited.

![image](/img/PB-catalog-translator-credit.png "An image of a mod's entry in Catalog, with a translator's name and a French flag")

### Crediting a Translator Who Didn't Use Parlay

If a translation was made using Parlay, it should have the translator’s name included so that you can credit them (or yourself, if you did the translating), but if it was made using another program, you can still credit them by manually editing the manifest after it’s completed. You can also do this to credit the creator of an existing translation.

The acceptable format to edit into the manifest is:

![image](/img/parlay-credit.png)

The standard languages available are (in alphabetical order by name in English):

* zh-CN – Chinese (Simplified)
* zh-TW – Chinese (Traditional)
* cs – Czech
* da – Danish
* nl – Dutch
* en-US – English (US)
* de – German
* fi – Finnish
* fr-FR – French (France)
* it – Italian
* ja – Japanese
* ko – Korean
* nb – Norwegian
* pl – Polish
* pt-BR – Portuguese (Brazil)
* ru – Russian
* es-ES – Spanish (Spain)
* sv – Swedish