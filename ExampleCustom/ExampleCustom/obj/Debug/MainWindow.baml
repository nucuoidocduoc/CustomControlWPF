   M S B A M L   `   `   `  ����H  DExampleCustom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ExampleCustomExampleCustom  5          ExampleCustom.MainWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      'localclr-namespace:ExampleCustom  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � Title$  
MainWindow��5	      ���	#FFE2E2E2$	��520��5      $	��830��5      .��5      � $��5,10,5,5q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   ]� $��0,0,0,10q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��	Project: ��6   �� 5      $	��100��6   5      �� 5      $ 
Horizontal=�6   $��15,0,0,0q�62   .+�5      �� $��Filter: ��6   �� 5      $	��100��6   5      �� 5      $��70��6   $��Edit/New��6#   $��Right=�66   5      �� 5   
   $��1��6   ��.  $��Visible=�6f   ��6    �� *	Clashes+��5       �� 5!       �� 
TargetType" ��6   .�5"      ��  �� Property � �� �� Value$ 0q�60   �� 5#       � ��$ 0q�6/   �� 5$       � ��$ 0q�68   �� 5%       � ��$ Stretch=�6C   5&      ��5(      �� 5)      .R�5*         ExampleCustom.Clash     Assign 5+      �� *Assign+   
ClashTitle 5,      �� *
ClashTitle+   	Tolerance 5-      �� *	Tolerance+	   	ClashName	 5.      �� *	ClashName+
   	DateFound
 5/      �� *	DateFound+   
ElementId1 50      �� *
ElementId1+   
ElementId2 51      �� *
ElementId2+   GridLocation 52      �� *GridLocation+   	ItemName1 53      �� *	ItemName1+   	ItemName2 54      �� *	ItemName2+   	ItemType1 55      �� *	ItemType1+   	ItemType2 56      �� *	ItemType2+   
LastUpdate 57      �� *
LastUpdate+   Layer1 58      �� *Layer1+   Layer2 59      �� *Layer2+   Path1 5:      �� *Path1+   Path2 5;      �� *Path2+   Status 5<      �� *Status+   
UpdateInfo 5=      �� *
UpdateInfo+.  (System.Windows.Interactivity.Interaction   Triggers 5?      /  )System.Windows.Interactivity.EventTrigger  5@         	EventName$
 Zoom��6-   .  (System.Windows.Interactivity.TriggerBase   Actions. 5A   "   6  0System.Windows.Interactivity.InvokeCommandAction     Command 68   �� *ZoomCommand+5B        5C      $ Show3D��6-   . 5D   "      68   �� *Show3DCommand+5E      5G      5H      5J      5K      5L      