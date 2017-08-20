namespace System.Reflection
{
    using System;

    [AttributeUsage(AttributeTargets.Assembly)]
    public class AssemblyLicenseAttribute : Attribute
    {
        private String m_license;

        public AssemblyLicenseAttribute(String description)
        {
            m_license = description;
        }

        public String License
        {
            get { return m_license; }
        }
    }
}