   M S B A M L   `   `   `  ����J  Fwpf_DataBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:wpf_DataBindingwpf_DataBinding  5   	        wpf_DataBinding.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:wpf_DataBinding     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5        $��slider1��5
   d   $
��Left=�6   $��
204,56,0,0q�6,   $	��Top=�6@   $	��304��6X    � Maximum$ 50Q�6s    � Minimum$ 0Q�6�    � Value$ 10Q�6�    �� TickPlacement$ TopLeft=�6�    �� TickFrequency$ 1Q�6�   �� 5   
   -   5         ��Name$ 	txtBlock1��5   �   $
��Left=�6   $��226,133,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $��28��6p   $	��282��6|   ��6�   ��  �� ElementName$ slider1�� �� Path$ Value�	 �� Mode$	 TwoWay=�6�   �� 5   
   -   5        $��txtBox1��5   �   $
��Left=�6   $��41��6-   $��226,197,0,0q�69   
 �� TextWrapping$

 Wrap=�6N   $	��Top=�6b   $	��208��6z   ��6�   �� $ 	txtBlock1��$
 Text� �� UpdateSourceTrigger$ PropertyChanged=�5      5      