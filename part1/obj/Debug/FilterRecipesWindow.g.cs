﻿#pragma checksum "..\..\FilterRecipesWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BE2DEC1B445596CD495443650D6EB31FE3F86E891B628225F0562E6BF3EBB37F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace RecipeApp {
    
    
    /// <summary>
    /// FilterRecipesWindow
    /// </summary>
    public partial class FilterRecipesWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\FilterRecipesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IngredientNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\FilterRecipesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FoodGroupTextBox;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\FilterRecipesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MaxCaloriesTextBox;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\FilterRecipesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox FilteredRecipesListBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/part1;component/filterrecipeswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FilterRecipesWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.IngredientNameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 6 "..\..\FilterRecipesWindow.xaml"
            this.IngredientNameTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.RemovePlaceholderText);
            
            #line default
            #line hidden
            
            #line 6 "..\..\FilterRecipesWindow.xaml"
            this.IngredientNameTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.AddPlaceholderText);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FoodGroupTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 7 "..\..\FilterRecipesWindow.xaml"
            this.FoodGroupTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.RemovePlaceholderText);
            
            #line default
            #line hidden
            
            #line 7 "..\..\FilterRecipesWindow.xaml"
            this.FoodGroupTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.AddPlaceholderText);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MaxCaloriesTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 8 "..\..\FilterRecipesWindow.xaml"
            this.MaxCaloriesTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.RemovePlaceholderText);
            
            #line default
            #line hidden
            
            #line 8 "..\..\FilterRecipesWindow.xaml"
            this.MaxCaloriesTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.AddPlaceholderText);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 9 "..\..\FilterRecipesWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.FilterRecipes_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.FilteredRecipesListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
