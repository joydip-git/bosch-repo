   M S B A M L   `   `   `  ����D  @wpf_First, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:wpf_First	wpf_First  5   	       wpf_First.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:wpf_First     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5
      � -   5         �Name$ grid1��5
      .+�5   
   �� -   5        $��slider1��5   �   $
��Left=�6   $��
172,90,0,0q�6,   $	��Top=�6@   $��26��6X   $	��381��6d    � Maximum$ 50Q�6p    � Minimum$ 0Q�6}    � Value$ 10Q�6�    �� TickPlacement$ TopLeft=�6�   �� 5   
   $��Slider Value: ��6   $
��Left=�6)   $��
160,43,0,0q�6D   $	��Top=�6X   $��30��6p   $	��106��6|   �� 5   
   -   5        $��txtSliderValue��5   �   $
��Left=�6   $��30��6-   $��
312,43,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6a   $	��173��6y   ��5      ��  �� ElementName$ slider1�� �� Path$ Value�	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=�5      5      