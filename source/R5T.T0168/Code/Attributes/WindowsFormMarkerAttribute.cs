using System;

using R5T.T0143;


namespace R5T.T0168
{
    /// <summary>
    /// Attribute indicating an class is a Windows Form.
    /// The marker attribute is useful for surveying Windows Forms and building a catalogue of functionality.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class WindowsFormMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zIsWindowsForm;
        /// <summary>
        /// Allows specifying that a class is *not* a Windows Form.
        /// This is useful for marking classes that end up canonical Windows Form code file locations, but are not Windows Forms.
        /// </summary>
        public bool IsWindowsForm
        {
            get
            {
                return this.zIsWindowsForm;
            }
        }


        public WindowsFormMarkerAttribute(
            bool isWindowsForm = true)
        {
            this.zIsWindowsForm = isWindowsForm;
        }
    }
}
