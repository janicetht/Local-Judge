   M S B A M L   `   `   `  ����E  ALocalJudge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LocalJudge
LocalJudge  5          LocalJudge.DisplayProblem   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:LocalJudge     5        � Title$  DisplayProblem��5	      
�������.��5      � .+�5   
   �� -   5         ��Name$ Program_TextBox��5      $
��Left=�6+   $��
25,152,0,0q�6F   $��#include<stdio.h>��6Z    �� TextWrapping$
 Wrap=�6y   $	��Top=�6�   $	��508��6�   $	��258��6�    �� AcceptsReturn$
 True��6�    �� 
AcceptsTab$
 True��6�   �� 5   
   -   5         ��Name$ ProblemTitle_TextBlock��5      $��Problem��64   $
��Left=�6C   $��	25,11,0,0q�6^   $	��Top=�6q   $��14(�6�   �� 5   
   -   5         ��Name$ Logout_Button��5      $��Logout��6(   $��14(�69   $
��Left=�6G   $��
722,14,0,0q�6b   $	��Top=�6v   $��58��6�   
�������$��26��6�   6�   �� 5   
   -   5        $ Description_TextBlock��5      $
��Left=�63   $��	34,76,0,0q�6N   $��	TextBlock��6a   $
��Wrap=�6r   $	��Top=�6�   $��48��6�   $	��442��6�   �� 5   
   $��Description��6   $
��Left=�6&   $��	25,45,0,0q�6A   $	��Top=�6T   �� 5   
   -   5        $ Author_TextBlock��5      $
��Left=�6.   $��
661,66,0,0q�6I   $��	TextBlock��6]   $
��Wrap=�6n   $	��Top=�6�   �� 5   
   $
��Left=�6   $��
568,95,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   �� 5   
   $
��Left=�6   $��
568,66,0,0q�6/   $��
Created By��6C   $
��Wrap=�6U   $	��Top=�6i   �� 5   
   -   5        $ Difficulty_TextBlock��5      $
��Left=�62   $��
661,98,0,0q�6M   $��	TextBlock��6a   $
��Wrap=�6r   $	��Top=�6�   �� 5   
   $
��Left=�6   $��
567,98,0,0q�6/   $��
Difficulty��6C   $
��Wrap=�6U   $	��Top=�6i   �� 5   
   $
��Left=�6   $��
25,131,0,0q�6/   $��Type your program here:��6C   $
��Wrap=�6b   $	��Top=�6v   �� 5   
   -   5        $ SelectFile_Button��5      $��Select File��6,   $
��Left=�6B   $��567,170,0,0q�6]   $	��Top=�6r   $��25��6�   $��91��6�   6�   �� 5   
   $
��Left=�6   $��567,150,0,0q�6/   $*��$Upload and submit an external C file��6D   $
��Wrap=�6p   $	��Top=�6�   �� 5   
   -   5        $ GoBack_Button��5      $��Go Back��6(   $��14(�6:   $
��Left=�6H   $��
636,14,0,0q�6c   $	��Top=�6w   $��26��6�   $��66��6�   6�   �� 5   
   -	   5        $ Submit_Button��5      $��Submit��6(   $
��Left=�69   $��552,383,0,0q�6T   $	��Top=�6i   $��27��6�   $��90��6�   6�   �� 5   
   -
   5        $ Filename_TextBlock��5      $
��Left=�60   $��667,173,0,0q�6K   $��Choose File��6`   $
��Wrap=�6s   $	��Top=�6�   5      5      