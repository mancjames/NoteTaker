// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace NoteTaker
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSScrollView previousNotes { get; set; }

		[Action ("deleteBtn:")]
		partial void deleteBtn (AppKit.NSButton sender);

		[Action ("loadBtn:")]
		partial void loadBtn (AppKit.NSButton sender);

		[Action ("LoadBtn:")]
		partial void LoadBtn (AppKit.NSButton sender);

		[Action ("newBtn:")]
		partial void newBtn (AppKit.NSButton sender);

		[Action ("newNoteBtn:")]
		partial void newNoteBtn (AppKit.NSButton sender);

		[Action ("saveBtn:")]
		partial void saveBtn (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (previousNotes != null) {
				previousNotes.Dispose ();
				previousNotes = null;
			}
		}
	}
}
