   M S B A M L   `   `   `  ????C  ?Interfaz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Interfaz.GraphViewsInterfaz.GraphViews  5   	   %    Interfaz.GraphViews.VertexFound   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Interfaz.GraphViews     5   	     ? Title$  Graphs??5   	   $	??450??6   $	??600??6%    ? AllowsTransparency$
 True??5	   	    ? WindowStartupLocation$ CenterScreen=?5
   	    ? WindowStyle$
 None=?5   	   
?????? .??5      ?? ???#f2f2f2 ?? CornerRadius$ 20??5      ._?5   
   ?  ? ColumnDefinitions 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5       ? RowDefinitions 5      ?? 5      $	??190 ?6    ?? 5      ?? 5      .+?5"      ?? $??1??6   $??3??5#      $??Vertex Found??5$      $??45(?5%      $??	0,100,0,0q?5&      ?? 5(      -   5        $??
txtVertexF??5*      $??3??5(      $??2??5)      $??100,100,0,10q?5+      $??N??5,      $??40(?5-       ?? TextAlignment$ Center=?5.      $??10q?5/      
????  ?50      ?? 52      -   5         ??Name$ btnBack??53      $??5??52      $
??Back??54      $??0,20,30,110q?55      $??15(?56      
?????? 
?????? ???#000$
??Bold"?5:      	 ? Cursor$
	 Hand??5;      6   ?? 5=      $??1??6   $??4??5>      $??1??5?      $,??&This node has the following conections??5@      $??15(?5A      
 ?? TextAlignment$
 Center=?5B      $??	0,20,0,90q?5C      ?? 5E      -   5         ??Name$ txtLinks??5E      $??1??5F      $??4??5G      $??1??5H      $??2??5I      $??70,60,70,60q?5J      $??
Conections??5K      $ Center=?5L      $??20q?5M      $??25(?5N      
???????5O      5P      5Q      5R      