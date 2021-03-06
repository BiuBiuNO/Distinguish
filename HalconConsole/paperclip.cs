//
// File generated by HDevelop for HALCON/.NET (C#) Version 19.05.0.0
// Non-ASCII strings in this file are encoded in local-8-bit encoding (cp936).
// 
// Please note that non-ASCII characters in string constants are exported
// as octal codes in order to guarantee that the strings are correctly
// created on all systems, independent on any compiler settings.
// 
// Source files with different encoding should not be mixed in one project.
//
//  This file is intended to be used with the HDevelopTemplate or
//  HDevelopTemplateWPF projects located under %HALCONEXAMPLES%\c#

using System;
using System.IO;
using HalconDotNet;

public partial class HDevelopExport
{
  public HTuple hv_ExpDefaultWinHandle;
  public string Path { get; set; } 
    public HDevelopExport()
    {

    }
    public HDevelopExport(string Path)
    {
        this.Path = Path;     
    }
  // Main procedure 
  public void action()
  {


    // Local iconic variables 

    HObject ho_Clip1, ho_Clip, ho_Dark, ho_Single;
    HObject ho_Selected;

    // Local control variables 

    HTuple hv_Width = new HTuple(), hv_Height = new HTuple();
    HTuple hv_Phi = new HTuple(), hv_Area = new HTuple(), hv_Row = new HTuple();
    HTuple hv_Column = new HTuple(), hv_Number = new HTuple();
    // Initialize local and output iconic variables 
    HOperatorSet.GenEmptyObj(out ho_Clip1);
    HOperatorSet.GenEmptyObj(out ho_Clip);
    HOperatorSet.GenEmptyObj(out ho_Dark);
    HOperatorSet.GenEmptyObj(out ho_Single);
    HOperatorSet.GenEmptyObj(out ho_Selected);
    ho_Clip1.Dispose();
    HOperatorSet.ReadImage(out ho_Clip1, Path);
    Console.WriteLine("open:"+ Path);
    ho_Clip.Dispose();
    HOperatorSet.Rgb1ToGray(ho_Clip1, out ho_Clip);
    hv_Width.Dispose();
    hv_Height.Dispose();
    HOperatorSet.GetImageSize(ho_Clip, out hv_Width, out hv_Height);
    Console.WriteLine(hv_Width.ToString());
    Console.WriteLine(hv_Height.ToString());
    ho_Dark.Dispose();
    HOperatorSet.Threshold(ho_Clip, out ho_Dark, 128, 255);
    ho_Single.Dispose();
    HOperatorSet.Connection(ho_Dark, out ho_Single);
    ho_Selected.Dispose();
    HOperatorSet.SelectShape(ho_Single, out ho_Selected, "area", "and", 5000, 10000);
    hv_Phi.Dispose();
    HOperatorSet.OrientationRegion(ho_Selected, out hv_Phi);
    hv_Area.Dispose();hv_Row.Dispose();hv_Column.Dispose();
    HOperatorSet.AreaCenter(ho_Selected, out hv_Area, out hv_Row, out hv_Column);
    Console.WriteLine(hv_Area.ToString());
    Console.WriteLine(hv_Row.ToString());
    Console.WriteLine(hv_Column.ToString());
    hv_Number.Dispose();
    HOperatorSet.CountObj(ho_Selected, out hv_Number);
    Console.WriteLine(hv_Number.ToString());
    Console.WriteLine("end");
    ho_Clip1.Dispose();
    ho_Clip.Dispose();
    ho_Dark.Dispose();
    ho_Single.Dispose();
    ho_Selected.Dispose();

    hv_Width.Dispose();
    hv_Height.Dispose();
    hv_Phi.Dispose();
    hv_Area.Dispose();
    hv_Row.Dispose();
    hv_Column.Dispose(); 
    hv_Number.Dispose();

  }

  public void InitHalcon()
  {
    // Default settings used in HDevelop
    HOperatorSet.SetSystem("width", 512);
    HOperatorSet.SetSystem("height", 512);
  }

  public void RunHalcon(HTuple Window)
  {
    hv_ExpDefaultWinHandle = Window;
    action();
  }

}

