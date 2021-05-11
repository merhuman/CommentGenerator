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
        #region CommentChars
        string squareBracketLeft = "";
        string squareBracketRight = "";
        #endregion
        #region UpperChars
        string upperA = @" ________     
|\   __  \    
\ \  \|\  \   
 \ \   __  \  
  \ \  \ \  \ 
   \ \__\ \__\
    \|__|\|__|";
        string upperB = @" ____  
| _ \ 
| |_) |
|  _<
| |_) |
|____/ ";
        string upperC = @"  _____ 
 / ____ |
| |
| |
| | ____ 
 \_____|";
        string upperD = @" _____  
|  __ \ 
| |  | |
| |  | |
| |__| |
|_____/ ";
        string upperE = @" ______ 
|  ____|
| |__   
|  __|  
| |____ 
|______|";
        string upperF = @" ______ 
|  ____|
| |__   
|  __|  
| |     
|_|     ";
        string upperG = @"  _____ 
 / ____|
| |  __ 
| | |_ |
| |__| |
 \_____|";
        string upperH = @" _    _ 
| |  | |
| |__| |
|  __  |
| |  | |
|_|  |_|";
        string upperI = @" _____ 
|_   _|
  | |  
  | |  
 _| |_ 
|_____|";
        string upperJ = @"      _ 
     | |
     | |
 _   | |
| |__| |
 \____/ ";
        string upperK = @" _  __
| |/ /
| ' / 
|  <  
| . \ 
|_|\_\";
        string upperL = @" _      
| |     
| |     
| |     
| |____ 
|______|";
        string upperM = @" __  __ 
|  \/  |
| \  / |
| |\/| |
| |  | |
|_|  |_|";
        string upperN = @" _   _ 
| \ | |
|  \| |
| . ` |
| |\  |
|_| \_|";
        string upperO = @"  ____  
 / __ \ 
| |  | |
| |  | |
| |__| |
 \____/ ";
        string upperP = @" _____  
|  __ \ 
| |__) |
|  ___/ 
| |     
|_|     ";
        string upperQ = @"  ____  
 / __ \ 
| |  | |
| |  | |
| |__| |
 \___\_\";
        string upperR = @" _____  
|  __ \ 
| |__) |
|  _  / 
| | \ \ 
|_|  \_\";
        string upperS = @"  _____ 
 / ____|
| (___  
 \___ \ 
 ____) |
|_____/ ";
        string upperT = @" _______ 
|__   __|
   | |   
   | |   
   | |   
   |_|   ";
        string upperU = @" _    _ 
| |  | |
| |  | |
| |  | |
| |__| |
 \____/ ";
        string upperV = @"__      __
\ \    / /
 \ \  / / 
  \ \/ /  
   \  /   
    \/    ";
        string upperW = @"__          __
\ \        / /
 \ \  /\  / / 
  \ \/  \/ /  
   \  /\  /   
    \/  \/    ";
        string upperX = @"__   __
\ \ / /
 \ V / 
  > <  
 / . \ 
/_/ \_\";
        string upperY = @"__     __
\ \   / /
 \ \_/ / 
  \   /  
   | |   
   |_|   ";
        string upperZ = @" ______
|___  /
   / / 
  / /  
 / /__ 
/_____|";
        #endregion
        #region LowerChars
        string lowera = @"  __ _ 
 / _` |
| (_| |
 \__,_|";
        string lowerb = @" _     
| |    
| |__  
| '_ \ 
| |_) |
|_.__/ ";
        string lowerc = @"  ___ 
 / __|
| (__ 
 \___|";
        string lowerd = @"     _ 
    | |
  __| |
 / _` |
| (_| |
 \__,_|";
        string lowere = @"  ___ 
 / _ \
|  __/
 \___|";
        string lowerf = @"  __ 
 / _|
| |_ 
|  _|
| |  
|_|  ";
        string lowerg = @"  __ _ 
 / _` |
| (_| |
 \__, |
  __/ |
 |___/ ";
        string lowerh = @" _     
| |    
| |__  
| '_ \ 
| | | |
|_| |_|";
        string loweri = @" _ 
(_)
 _ 
| |
| |
|_|";
        string lowerj = @"   _ 
  (_)
   _ 
  | |
  | |
  | |
 _/ |
|__/ ";
        string lowerk = @" _    
| |   
| | __
| |/ /
|   < 
|_|\_\";
        string lowerl = @" _ 
| |
| |
| |
| |
|_|";
        string lowerm = @" _ __ ___  
| '_ ` _ \ 
| | | | | |
|_| |_| |_|";
        string lowern = @" _ __  
| '_ \ 
| | | |
|_| |_|";
        string lowero = @"  ___  
 / _ \ 
| (_) |
 \___/ ";
        string lowerp = @" _ __  
| '_ \ 
| |_) |
| .__/ 
| |    
|_|    ";
        string lowerq = @"  __ _ 
 / _` |
| (_| |
 \__, |
    | |
    |_|";
        string lowerr = @" _ __ 
| '__|
| |   
|_|   ";
        string lowers = @" ___ 
/ __|
\__ \
|___/";
        string lowert = @" _   
| |  
| |_ 
| __|
| |_ 
 \__|";
        string loweru = @" _   _ 
| | | |
| |_| |
 \__,_|";
        string lowerv = @"__   __
\ \ / /
 \ V / 
  \_/  ";
        string lowerw = @"__      __
\ \ /\ / /
 \ V  V / 
  \_/\_/  ";
        string lowerx = @"__  __
\ \/ /
 >  < 
/_/\_\";
        string lowery = @" _   _ 
| | | |
| |_| |
 \__, |
  __/ |
 |___/ ";
        string lowerz = @" ____
|_  /
 / / 
/___|";
        #endregion
    }
}
