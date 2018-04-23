# How the LayoutUnit property affects the display and printout appearance 


<p>This example illustrates the effect of the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraRichEditRichEditControl_LayoutUnittopic"><u>RichEditControl.LayoutUnit</u></a> property settings on the visual appearance of characters in a document. <br />
Left boxes are the RichEditControls, boxes on the right are the <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraPrintingControlPrintControltopic"><u>PrintControls</u></a> containing RichEditControl's document content printed via the <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraPrintingPrintingSystemtopic"><u>PrintingSystem</u></a>.<br />
The RichEditControl at the top has a default <strong>LayoutUnit </strong>setting. It has the <i>DocumentLayoutUnit.Document</i> value.<br />
The RichEditControl at the bottom has a <strong>LayoutUnit </strong>setting of the <i>DocumentLayoutUnit.Pixel</i> value.</p><p>You can change the text in the top left RichEditControl or load a new document in it via the Ctrl-O command. Other controls are synchronized with the content of the top left control.<br />
Observe the differences in character spacing, pagination and font appearance.</p><p><strong>NOTE</strong>: Starting with DXperience 12.1, the default value of the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraRichEditRichEditControl_LayoutUnittopic"><u>RichEditControl.LayoutUnit</u></a> property is <strong>DocumentLayoutUnit.Pixel.</strong></p>

<br/>


