using MAUI_Custom_List.Common;
using Microsoft.Maui.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Custom_List.Controls
{
      internal class SimpleRatingControl : HorizontalStackLayout
        {
            public static readonly BindableProperty CurrentValueProperty =
                 BindableProperty.Create(
                     nameof(CurrentValue),
                     typeof(double),
                     typeof(SimpleRatingControl),
                     defaultValue: 0d,
                     propertyChanged: OnRefreshControl);

            public double CurrentValue
            {
                get => (double)GetValue(CurrentValueProperty);
                set => SetValue(CurrentValueProperty, value);
            }

            public static readonly BindableProperty AmountProperty =
              BindableProperty.Create(
                  nameof(Amount),
                  typeof(int),
                  typeof(SimpleRatingControl),
                  defaultValue: 10,
                  propertyChanged: OnRefreshControl);

            public int Amount
            {
                get => (int)GetValue(AmountProperty);
                set => SetValue(AmountProperty, value);
            }

            public static readonly BindableProperty StarSizeProperty =
              BindableProperty.Create(
                  nameof(StarSize),
                  typeof(double),
                  typeof(SimpleRatingControl),
                  defaultValue: 24d,
                  propertyChanged: OnRefreshControl);

            public double StarSize
            {
                get => (double)GetValue(StarSizeProperty);
                set => SetValue(StarSizeProperty, value);
            }

            public static readonly BindableProperty AccentColorProperty =
                BindableProperty.Create(
                    nameof(AccentColor),
                    typeof(Color),
                    typeof(SimpleRatingControl),
                    defaultValue: Colors.Red,
                    propertyChanged: OnRefreshControl);

            public Color AccentColor
            {
                get => (Color)GetValue(AccentColorProperty);
                set => SetValue(AccentColorProperty, value);
            }


            private static void OnRefreshControl(BindableObject bindable, object oldValue, object newValue)
            {
                if (bindable is SimpleRatingControl ratingControl)
                    ratingControl.UpdateLayout();
            }


            public SimpleRatingControl()
            {
                Spacing = -8;
                UpdateLayout();
            }

        //The whole magic is happing in the UpdateLayout method. First we remove all the children within the HorizontalStackLayout. Then we need to calculate the star state. For this we just check the decimal part of CurrentValue. If the value is below .25 we don’t need to do anything. If this value is between .25 and .75 we need to draw a half star. And if the value is greater than .75 we need to draw a full star.
        private void UpdateLayout()
            {
                Children.Clear();

                var intValue = (int)ClampValue(CurrentValue);
                var decimalPart = CurrentValue - intValue;
                var isHalfStarNeeded = false;

                if (decimalPart > .25)
                {
                    if (decimalPart > 0.25 && decimalPart <= .75)
                        isHalfStarNeeded = true;
                    else
                        intValue++;
                }

                for (int i = 0; i < Amount; i++)
                {
                    if (intValue > i)
                    {
                        Add(CreateStarLabel(StarState.Full));
                    }
                    else if (intValue <= i && isHalfStarNeeded)
                    {
                        Add(CreateStarLabel(StarState.Half));
                        isHalfStarNeeded = false;
                    }
                    else
                    {
                        Add(CreateStarLabel(StarState.Empty));
                    }
                }
            }
        //The next helper method is CreateStarLabel and as you might have guessed it will create the Label which then will be added to our HorizontalStackLayout. We need to make sure that we set the FontFamily to our added font and also decide which Text should be shown. Luckily there is a glyph for each state.
        private Label CreateStarLabel(StarState state)
            {
                return new Label
                {
                    FontFamily = "MaterialDesignIcons",
                    TextColor = AccentColor,
                    FontSize = StarSize,
                    Text = state switch
                    {
                        StarState.Empty => MaterialDesignIconsFont.StarOutline,
                        StarState.Half => MaterialDesignIconsFont.StarHalfFull,
                        StarState.Full => MaterialDesignIconsFont.Star,
                        _ => MaterialDesignIconsFont.StarOutline,
                    }
                };
            }
        // The method ClampValue makes sure that the CurrentValue and 
        //the Amount are matching. By validating that CurrentValue is between 0 and Amount.
        private double ClampValue(double value)
            {
                if (value < 0)
                    return 0;

                if (value > Amount)
                    return Amount;

                return value;
            }
        }
    }
 
