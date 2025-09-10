﻿using System;
namespace TitleGame
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class RequireSettingAttribute : Attribute
    {
        public string name;
        public PrefsSettings.FieldType fieldType;

        public RequireSettingAttribute(string name, PrefsSettings.FieldType fieldType)
        {
            this.name = name;
            this.fieldType = fieldType;
        }
    }
}
