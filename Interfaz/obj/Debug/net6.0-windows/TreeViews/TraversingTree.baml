   M S B A M L   `   `   `  ????C  ?Interfaz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Interfaz.TreeViewsInterfaz.TreeViews  5   	   '    !Interfaz.TreeViews.TraversingTree   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Interfaz.TreeViews     5   	     ? Title$  Trees??5   	   $	??450??6   $	??600??6$    ? AllowsTransparency$
 True??5	   	    ? WindowStartupLocation$ CenterScreen=?5
   	    ? WindowStyle$
 None=?5   	   
?????? .??5      ?? ???#f2f2f2 ?? CornerRadius$ 20??5      ._?5   
   ?  ? ColumnDefinitions 5      ?? 5       ? RowDefinitions 5      ?? 5      $??60 ?6    ?? 5      $??30 ?6    ?? 5      ?? 5      $??30 ?6    ?? 5      ?? 5      $??30 ?6    ?? 5      .+?5!      ?? -   5         ??Name$ btnBack??5"      $??0??5!      $
??Back??5#      $??500,20,40,0q?5$      $??15(?5%      
?????? 
?????? ???#000$
??Bold"?5)       ? Cursor$
 Hand??5*      ?? 5,      $??1??6   $??Center=?5-      $
??70,0q?5.      $??	In Order:??5/      $??20(?50      $
??Bold"?51      ?? 53      -   5        	 ??Name$	 
txtInOrder??55      $??2??53      $??A-B-C-D??54      $??70,10,100,50q?56      
 ?? Padding$

 20,0q?57      ???#fff
???????$??25(?5:      $??DemiBold"?5;      ?? 5=      $??3??6   $??Center=?5>      $
??70,0q?5?      $??
Pre Order:??5@      $??20(?5A      $
??Bold"?5B      ?? 5D      -   5        $	 txtPreOrder??5E      $??4??5D      $??70,10,100,50q?5F      $

 20,0q?5G      ???#fff
???????$??25(?5J      $??DemiBold"?5K      ?? 5M      $??5??6   $??Center=?5N      $
??70,0q?5O      $??Post Order:??5P      $??20(?5Q      $
??Bold"?5R      ?? 5T      -   5        $	 txtPostOrder??5U      $??6??5T      $??70,10,100,50q?5V      $

 20,0q?5W      ???#fff
???????$??25(?5Z      $??DemiBold"?5[      5^      5`      5a      