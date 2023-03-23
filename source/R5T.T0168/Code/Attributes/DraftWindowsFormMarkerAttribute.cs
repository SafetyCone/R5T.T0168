using System;

using R5T.T0143;


namespace R5T.T0168
{
    /// <summary>
    /// Attribute indicating an class is a draft Windows Form.
    /// The marker attribute is useful for surveying for draft Windows Forms and building a catalogue of draft Windows Forms as a kind of TODO list.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class DraftWindowsFormMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zIsWindowsFormDraft;
        /// <summary>
        /// Allows specifying that an interface is *not* a draft Windows Form.
        /// This is useful for marking classes that end up canonical draft Windows Form code file locations, but are not draft Windows Forms.
        /// </summary>
        public bool IsWindowsFormDraft
        {
            get
            {
                return this.zIsWindowsFormDraft;
            }
        }


        public DraftWindowsFormMarkerAttribute(
            bool isWindowsFormDraft = true)
        {
            this.zIsWindowsFormDraft = isWindowsFormDraft;
        }
    }
}
