# StretchedList
Used to return a list evenly over a number of frames.

This is used in a game im creating to handle mob ai in a persistant world
as oppose to doing this:

int counter =0;
UpdateLoop() {
  counter++
  if (counter == 10) 
  {
     for (int i =0; i<mobs.count;i++) 
     {
      mobs[i].doAI();
     }
     counter = 0;
  }
}

which results in a spike every counter==10
we do 10% (noOfFrames%) of the list per frame with it accounting for deleting and adding to the list through the rest of the game loop.

keep in mind if what ur doing in the list is time sensitive (mobai) you need to track last time either per mob or per list iteration and account for thatt

