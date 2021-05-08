using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLibs
{
    public abstract class CommentType
    {
        string upperA, upperB, upperC, upperD;
        string lowerA, lowerB, lowerC, lowerD;
    }

    public class Type_3D_ASCII : CommentType
    {
        string upperA = @" ________     
|\   __  \    
\ \  \|\  \   
 \ \   __  \  
  \ \  \ \  \ 
   \ \__\ \__\
    \|__|\|__|";
        string upperB = "";
        string upperC = "";
        string upperD = "";
        string upperE = "";
        string upperF = "";
    }
}
