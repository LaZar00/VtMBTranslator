# CompareDLG4VtmB

This tool mainly allows you to perform a translation of the .dlg and .lip files of the game Vampire the Masquerade: Bloodlines. It also allows you to re-encode the .lips and prepare the necessary .mp3/.wav/.vcd files in case you need to generate new genre-based lines.

This tool has been prepared to update also an existing translation and apply the old lines to the new version. However, a manual check is needed to verify that the lines are correct (that the context of the lines remains the same). The possibility to use an external translator such as DEEPL has also been added.

## Main Window
This is the main window of VtMBTranslator:

![imagen](https://github.com/user-attachments/assets/577b8bbf-654c-41ac-b28a-21f40b67b650)

You here have two grids. In the left one, the Primary, we will open the .dlg file to translate (mainly from english version). In the Secondary one, we can open an old version with the lines translated or even open another english instance to check our translation while doing the rest of the lines.
To edit the lines, we must double-click in one row of th grid. If we click in Male or Female column, we will open the Everyone Data editor. If we click in some of the columns of the clans, we will open the Clans Data editor. We can also push the buttons for the same effect.
The compare buttons are for compare the lines among the Primary and Secondary rows and it will show the differences.
We can also go to a line of the datagrid (CTRL+G) or even find a string in the Primary or Secondary grids, with case sensitivity (CTRL+F).

Other options of this main window are:
- Individual Lips Editor: (This will open the editor for individual lips texts that are not in .dlg files.
- Encoding (Char/Unicode): With this we will tell the tool if we want the lips data in Unicode or Char format.
- Open in Text Editor: We will open in our default windows text editor both .dlg files opened in Primary and Secondary grids.
- We can Save or Save As... our Primary dialog file.
- Update Lips: With this button we will open a window where we will be able to regenerate the .lips,.mp3/.wav,.vcd files.


## Edit Everyone
In this window we will be able to translate Male and Female lines:

![imagen](https://github.com/user-attachments/assets/60ea6805-ed55-4ef4-9ae2-d83a67c78020)

You will see Male and Female lines of the selected row. AND you will see the data of the lines for Primary (editable/white) and Secondary (non-editable/gray) dialogue files.
Once we have translated the line we MUST validate it. We have here some options like Validate and go to next/previous row, or Copy the data from Secondary to Primary for going faster with the translate process, for example, if we are adapting an old translation. Remember, we ALWAYS need to validate the row to write it in the Primary grid. We can advance or back the rows with the "<<" and ">>" buttons.
There is the option of use DEEPL (button with the icon), and it will translate ONLY the Male line of Primary dialog file. The top most textbox.
Finally, we have the choise to see the referents. This button helps to know what we have answered before the NPC says this line (only works with lines with # symbol) in case we lost the context.
When we have done the changes, we can close (or press ESC) this window.

Here we have 2 checkboxes:
- Change all lines: With this, all the lines in a dialog file with the same text are translated at the same time. This happens when we validate the text.
- Jump empty rows: With this checked, we go to next/previous row that contains text, so we avoid to select empty rows.


## Edit Clans
This is more or less the very same as Edit Everyone window. The only difference is that we have the 7 clans textboxes in a similar manner as in Edit Everyone. Remember that we have not gender lines here, se we should try to unisex all the lines in clans choices. As far as I've seen, only Malkavian and Ventrue has texts in main VtMB game.
Here you have also the same check boxes and the methodology of work is the same as in Edit Everyone, and you can translate directly from DEEPL with the buttons, V for Ventrue and M for Malkavian.

![imagen](https://github.com/user-attachments/assets/e6bc5725-f2b4-4c66-843d-09f2e250af99)


## Update Lips
With this window you will be able to regenerate the .lips, .mp3/.wav and .vcd files, adding or deleting those that changed maingly its gender. It seems the game differences if Male/Female line is used, but you need to have synchroniced that files (lip/mp3/wav/vcd) to make them work in-game.
I created a folder "structure" that you can follow to regenerate all this files. I recommend to do all this outside of the main folders of the game or Unofficial Patch. Then, when we have it in the result folder, we can copy that folder with all the regenerated lines.

![imagen](https://github.com/user-attachments/assets/e97dce23-f383-4d1d-8441-ccebcb362947)

Here we will have to select each of the folders, I did this way because make it more understandable when I had to search something for update it if needed.
Then we must check the process to test if folders are all prepared. Once is all ok, the button for "Translate lip files and Generate..." is enabled.
We can push it and in result path we will have all the files regenerated.
We can also translate the Speaker Name to our language if we want. In case we had done this process previously, you will see it, and will be able to copy it directly with the butoon "<-".


## Individual Lips editor
With this window, we will be able to edit those .lip files that are not included in .dlg files. I recommend also to do it externally, and not directly from the VtMB folders of the game. The only files not editable with this window/tool, are those of the "radio" folder.

![imagen](https://github.com/user-attachments/assets/b9ee0f3a-44e2-4519-ba9d-e643c324ce2b)

You can select from the treeview the .lip file. And you will have at the right the text translated (top textbox), and the original text (bottom textbox). Please, have in mind that this text is THE SAME. ONCE WE PUSH VALIDATE, THE TEXT WILL BE THE SAME IN BOTH TEXTBOXES. You can always open in another editor the original english text, but in this window we don't use two different files. We always use the same file.
We have also the option to use DEEPL for the translation of the most top textbox.
We can also translate the Speaker Name if needed.
Finally, when we are ok with the translation, we MUST push the validate button to save the changes into the file. If you quit without validate, the changes ARE NOT SAVED.

