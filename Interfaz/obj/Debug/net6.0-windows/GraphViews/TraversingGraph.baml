   M S B A M L   `   `   `  ????C  ?Interfaz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Interfaz.GraphViewsInterfaz.GraphViews  5   	   )    #Interfaz.GraphViews.TraversingGraph   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Interfaz.GraphViews     5   	     ? Title$  Trees??5   	   $	??450??6   $	??600??6$    ? AllowsTransparency$
 True??5	   	    ? WindowStartupLocation$ CenterScreen=?5
   	    ? WindowStyle$
 None=?5   	   
?????? .??5      ?? ???#f2f2f2 ?? CornerRadius$ 20??5      ._?5   
   ?  ? ColumnDefinitions 5      ?? 5      ?? 5       ? RowDefinitions 5      ?? 5      $	??180 ?6    ?? 5      $??80 ?6    ?? 5      $
??Auto ?6    .+?5      ?? -   5         ??Name$ btnBack??5      $??1??5      $
??Back??5      $??200,30,30,120q?5       $??15(?5!      
?????? 
?????? ???#000$
??Bold"?5%       ? Cursor$
 Hand??5&      ?? 5(      $??0??6   $??2??5)      $??
Traversing??5*      $??50(?5+      	 ?? TextAlignment$	 Center=?5,      $??0,50,0,0q?5-      ?? 5/      $??0??6   $??2??50      $2??,Please choose a method to traverse the graph??51      $??13(?52      $	 Center=?53      $??	0,160,0,0q?54      ?? 56      -   5        $ btnDepht??56      $??Depth First??57      $??0??58      $??1??59      $??1??5:      $	??130??5;      $??50??5<      $??
120,30,0,0q?5=      ???#000???#fff$??17(?5@      $??DemiBold"?5A      $
 Hand??5B      5C      ?? 5E      -   5        $ 
btnBreadth??5E      $??Breadth First??5F      $??1??5G      $??1??5H      $??1??5I      $	??130??5J      $??50??5K      $??
0,30,120,0q?5L      ???#000???#fff$??17(?5O      $??DemiBold"?5P      $
 Hand??5Q      5R      ?? 5T      -   5        
 ??Name$
 txtTraverse??5T      $??0??5U      $??2??5V      $??2??5W      $??V-V-V-V??5X      $	??350??5Y      $??50??5Z      $
??0,50q?5[       ?? TextAlignment$ Center=?5\      $??30(?5]      $
??Bold"?5^      
???????5_      5a      5b      5c      