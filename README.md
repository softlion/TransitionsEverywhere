# TransitionsEverywhere
Bindings of the [TransitionsEverywhere lib](https://github.com/andkulikov/Transitions-Everywhere) for Xamarin Android

# Usage

[Author Blog entry on medium](https://medium.com/@andkulikov/animate-all-the-things-transitions-in-android-914af5477d50#.l1amxf3ry)


# Sample

        var transition = Com.Transitionseverywhere.TransitionManager.DefaultTransition;
        transition.SetDuration(400);
        transition.SetInterpolator(new FastOutSlowInInterpolator());
        transition.AddListener(new TransitionListener { EndAction = () => 
        {
            //Some stuff
        }});
        Com.Transitionseverywhere.TransitionManager.BeginDelayedTransition(parent, transition);
        
        //Add your view updates here. These should be animated.
