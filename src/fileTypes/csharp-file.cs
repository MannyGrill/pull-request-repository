/*
  This file is part of the Microsoft .NET Framework SDK Code Samples.
*/
using System;
using System.Collections;
using System.Text;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace Microsoft.Samples.TimeZoneConvertCS {
  /// TimeZoneCollection
  /// implements a sorted list of TimeZones by reading the Windows 
  /// Registry (there's currently no other way to do it)
  public class TimeZoneList : System.Collections.ArrayList {
    public TimeZoneList() {
      //initialize the list
      this.Initialize();  
    }

    public TimeZone this[string name] {
      get {
        int i;
        for (i = 0; i < this.Count; i++) {
          if (((TimeZone)base[i]).StandardName == name) {
            break;
          }
        }
        if (i == this.Count) {
          return null;
        } else {
          return (TimeZone)base[i];
        }
      }
      set { base.Add(this); }
    }