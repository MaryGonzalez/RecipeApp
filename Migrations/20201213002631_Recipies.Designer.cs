﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecipeApplication.Models;

namespace RecipeApplication.Migrations
{
    [DbContext(typeof(RecipeContext))]
    [Migration("20201213002631_Recipies")]
    partial class Recipies
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("RecipeApplication.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "B",
                            Name = "Breakfast"
                        },
                        new
                        {
                            CategoryId = "D",
                            Name = "Desserts"
                        },
                        new
                        {
                            CategoryId = "V",
                            Name = "Main Dishes-Vegetarian"
                        },
                        new
                        {
                            CategoryId = "M",
                            Name = "Main Dishes-Meat"
                        });
                });

            modelBuilder.Entity("RecipeApplication.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Directions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrepTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Servings")
                        .HasColumnType("int");

                    b.Property<string>("TotalTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecipeId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            RecipeId = 1,
                            Author = "Betty Crocker Kitchens",
                            CategoryId = "D",
                            Directions = "1. Heat oven to 375°F. In small bowl, mix flour, baking soda and salt; set aside.  2. In large bowl, beat softened butter and sugars with electric mixer on medium speed, or mix with spoon about 1 minute or until fluffy, scraping side of bowl occasionally. 3. Beat in egg and vanilla until smooth. Stir in flour mixture just until blended (dough will be stiff). Stir in chocolate chips and nuts. 4. Onto ungreased cookie sheets, drop dough by rounded tablespoonfuls 2 inches apart. 5. Bake 8 to 10 minutes or until light brown(centers will be soft).Cool 2 minutes; remove from cookie sheet to cooling rack.Cool completely, about 30 minutes.Store covered in airtight container.",
                            Image = "ChocolateChip.jpg",
                            Ingredients = "2 1/4 cups Gold Medal all-purpose flour, 1 teaspoon baking soda, 1/2 teaspoon salt, 1 cup butter (softened), 3/4 cup granulated sugar, 3/4 cup packed brown sugar, 1 egg, 1 teaspoon vanilla, 2 cups semisweet chocolate chips, 1 cup coarsely chopped nuts (if desired)",
                            Name = "Ultimate Chocolate Chip Cookies",
                            PrepTime = "15 minutes",
                            Servings = 48,
                            TotalTime = "1 Hour, 30 Minutes"
                        },
                        new
                        {
                            RecipeId = 2,
                            Author = "The Salty Marshmallow",
                            CategoryId = "B",
                            Directions = "1. Preheat your waffle iron, spray with non stick cooking spray and set aside. 2. In a large bowl whisk together the flour,baking powder, sugar, salt, and cinnamon. 3. In a medium bowl beat the egg whites with a hand mixer until stiff peaks form. Set aside. 4. In a separate medium bowl mix together the egg yolks, vegetable oil, milk, and vanilla extract. 5. Add the egg yolk mixture to the dry ingredients and mix well. 6. Fold in the egg whites. 7. Pour the batter onto your hot waffle iron and cook according to manufacturer's direction 8. Serve immediately with butter, syrup, powdered sugar or any other favorite toppings.",
                            Image = "BelgianWaffles.jpg",
                            Ingredients = "2 1/4 Cups All Purpose Flour, 1 Tablespoon Baking Powder, 3 Tablespoons Sugar, 1/2 Teaspoon Salt, 1 Teaspoon Cinnamon, 2 Large Eggs Separated, 1/2 Cup Vegetable Oil, 2 Cups Milk, 1 Teaspoon Vanilla Extract",
                            Name = "Homemade Belgian Waffles",
                            PrepTime = "15 minutes",
                            Servings = 8,
                            TotalTime = "35 minutes"
                        },
                        new
                        {
                            RecipeId = 3,
                            Author = "Peas and Carrots",
                            CategoryId = "V",
                            Directions = "1. Drain and rinse your chickpeas and add them to a large bowl. Mash with a potato masher until texture appears flaked, almost like tuna salad. I use both a potato masher and follow up with a fork to make sure every chickpea is deliciously smashed. You could also use a food processor2. Chop your green onion, celery, shredded carrots, pepper, and pickles. 3. Add to the bowl with your chickpeas, then add mayo, dijon, yellow mustard, dill, salt, and pepper. Stir well to coat.4. Fold in sunflower seeds and basil (as much or as little as you’d like) and adjust any ingredients to taste. 5. Pile high on bread with all your sandwich fixings or enjoy as a wrap, with crackers, on a salad, or simply dive into the bowl spoon-first – anything goes!",
                            Image = "GardenVeggie.jpg",
                            Ingredients = "15 oz canned chickpeas, drained + rinsed, 3 stalks green onion, 2 stalks celery, 1/4 cup chopped , shredded carrots, 1/4 cup finely chopped red bell pepper, 1/4 cup finely chopped dill pickle, 1/4 cup mayonnaise vegan or regular ,1-2 tsp Dijon mustard, 1 tsp yellow mustard, 1/8 tsp dried dill or fresh, to taste, 1/8 tsp salt, 1/8 tsp pepper, 3 TBSP unsalted roasted sunflower seeds, 2 TBSP fresh chopped basil plus extra to taste",
                            Name = "Garden Veggie Chickpea Salad Sandwich",
                            PrepTime = "15 minutes",
                            Servings = 4,
                            TotalTime = "15 Minutes"
                        },
                        new
                        {
                            RecipeId = 4,
                            Author = "Recipe Girl",
                            CategoryId = "M",
                            Directions = "1. If you'd like to serve this dinner with rice, start this meal by cooking the brown rice according to package directions. Let sit 10 minutes before fluffing. While rice cooks, prep and bake the veggies and sausage.2. Preheat the oven to 400 degrees F. Place all vegetables and sausage on a large rimmed, 18x13-inch sheet pan that has been sprayed with nonstick spray.3. Drizzle the veggies and sausage with olive oil and sprinkle with Italian seasoning, kosher salt, and black pepper. Mix it all together with your hands and spread it out evenly on the pan.4. Bake for 20 to 25 minutes (stirring after 15 minutes) until the vegetables are cooked to fork tender. 5. Serve warm with rice",
                            Image = "PanVeggies.jpg",
                            Ingredients = "1 cup uncooked brown rice (optional), 13 ounces Turkey Polska Kielbasa (or any other smoked sausage), 2 cups baby carrots (halved, if large), 2 cups broccoli florets, 1 cup sliced onions, 2 cups green beans, 1 medium red bell pepper (seeded & cut into 1 inch pieces), 2 medium garlic cloves minced, 3 tablespoons olive oil, 2 tablespoons Italian seasoning, 1 teaspoon kosher salt (or 1/2 teaspoon table salt), 1/2 teaspoon ground black pepper",
                            Name = "Sheet Pan Roasted Veggies and Sausage",
                            PrepTime = "10 Minutes",
                            Servings = 4,
                            TotalTime = "35 Minutes"
                        },
                        new
                        {
                            RecipeId = 5,
                            Author = "Baker by Nature",
                            CategoryId = "D",
                            Directions = "1. Place the ricotta cheese into a fine mesh strainer and place it in the fridge to drain for at least 12 hours and up to 24 hours.2. When you're ready to make the filling:3. In a large bowl combine the drained ricotta cheese, confectioners' sugar, 1/4 cup of the mini chocolate chips, vanilla extract, and orange zest (if using); mix well. Using a spatula, carefully scrape the mixture into pastry bag fitted with a 1/2 inch open tip. Use at once, or refrigerate until needed; filling can be made up to 24 hours in advance.4. When ready to serve, pipe the filling into one end of cannoli shell, filling shell halfway, then pipe into other end. If you don't have a piping bag, you may spoon the filling into the shells. Repeat with remaining shells.5. Place remaining mini chocolate chips on a small plate. Dip each end of the cannoli into the chocolate chips, then lightly dust with confectioner's sugar. Serve at once.",
                            Image = "Cannolis.jpg",
                            Ingredients = "8 cannoli shells, homemade or store bought will work, 2 cups ricotta cheese, 1 cup confectioners' sugar  plus extra for dusting, 3/4 cup mini chocolate chips  divided, 1 and 1/2 teaspoons pure vanilla extract, Optional: 2 teaspoons fresh orange zest",
                            Name = "5-Ingredient Cannolis",
                            PrepTime = "15 Minutes",
                            Servings = 8,
                            TotalTime = "12 Hours, 15 Minutes"
                        },
                        new
                        {
                            RecipeId = 6,
                            Author = "With Peanut Butter on Top",
                            CategoryId = "B",
                            Directions = "1. Heat a small nonstick pan over medium heat. Add the bacon and cook until it reaches desired doneness. When cooked, remove to a plate with a paper towel to keep warm and absorb some of the bacon grease.2. Pour out or wipe out the bacon grease from the pan with a paper towel. Lower the heat to medium-low. Add 1 tablespoon of butter and allow it to melt.3. While the butter is melting and warming, whisk two eggs into a medium-sized mixing bowl until the yolk is fully incorporated.4. Pour the eggs into the pan when the butter starts to bubble. This is when you know the pan is heated.5. Using a wooden spoon, make swirls throughout the eggs, making sure to scrape along the edges of the pan. This helps to cook the eggs more evenly in my opinion. Make swirls for 1-2 minutes and let it finally set and cook flat so that you can start folding it over.6. Season with salt, pepper, and garlic powder - all to taste. I use a pinch or two of garlic7. Remove from heat just before it looks done. It will continue cooking in the hot pan as you fold.8. Using a small, flat spatula (not a rubber spatula), start turning the edges over in small folds, while going in a circle around the pan. Think of a floured tortilla being folded to close a quesadilla.9. Sprinkle some cheese on top to melt, if desired.10. While you're waiting for the eggs to cook, toast the bagel and mash the avocado in a small bowl. Season with salt, pepper, and a pinch of garlic powder (if desired).11. To the top bagel, spread the cream cheese. To the bottom, spread the garlic avocado mash. Layer the avocado mash with the eggs and season with freshly chopped chives and red pepper flakes (optional). Add the bacon and tomato slices. Enjoy!",
                            Image = "BaconBagel.jpg",
                            Ingredients = "1 Everything Bagel, 2 large eggs, 1 tbsp light butter, 2 tbsp low-fat cream cheese, 1 slice bacon, 1/4 medium avocado, 2 slices tomato, salt and pepper, garlic powder",
                            Name = "Bacon Egg and Avocado Breakfast Bagel",
                            PrepTime = "5 Minutes",
                            Servings = 2,
                            TotalTime = "15 Minutes"
                        },
                        new
                        {
                            RecipeId = 7,
                            Author = "Power Hungry",
                            CategoryId = "V",
                            Directions = "1. Heat the oil in a large saucepan set over medium heat. Add the onions; cook and stir for 6 to 9 minutes until onions begin to turn brown. Add the garlic and rosemary; cook and stir for 1 minute longer. 2. Add the water, potatoes, 3/4 teaspoon salt and 1/8 teaspoon black pepper. Bring to a low boil, reduce heat to low and simmer uncovered for 30 to 35 minutes until the potatoes are very tender. Using the back of a kitchen spoon, coarsely mash some of the potatoes.3. Add the beans and kale to the soup; cook 4 to 7 minutes longer or until kale is wilted and tender. Remove from heat and season to taste with additional salt and pepper, as desired.",
                            Image = "KaleSoup.png",
                            Ingredients = "2 teaspoons olive oil, 1 medium onion, finely chopped, 4 cloves garlic, minced, 2 teaspoons minced fresh rosemary leaves, 4 cups water, 1 pound white or gold potatoes, peeled, cut into small cubes, fine sea salt & ground black pepper, 1 15-ounce can white beans, rinsed and drained, 3 cups coarsely chopped kale (tough ribs removed)",
                            Name = "Kale, Potato & White Bean Soup",
                            PrepTime = "10 Minutes",
                            Servings = 4,
                            TotalTime = "55 Minutes"
                        },
                        new
                        {
                            RecipeId = 8,
                            Author = "Evolving Table",
                            CategoryId = "M",
                            Directions = "1. Preheat oven to 375 degrees.2. Prepare chicken by pounding to 1-inch thick and cutting into 4-5 ounce portions.3. Whisk mustard, honey, oil, Worcestershire, thyme, garlic, salt, pepper, and paprika in a large bowl until smooth.4. Reserve 2 tablespoons of the honey mustard sauce.5. Place chicken into the bowl with the sauce. Toss until chicken is well coated.6. Marinate chicken in the refrigerator for at least 20 minutes, or up to overnight. (You can transfer it to a gallon-sized Ziploc bag for easier storage.)7. Place chicken breasts in a 9-inch square baking dish that has been lightly coated with non-stick cooking spray.8. Bake chicken in preheated oven for 20-25 minutes, or until the internal temperature reaches 160 degrees. (It will increase by 5-10 degrees once removed from the oven reaching a final temperature of 165 degrees.)9. Brush chicken with reserved honey mustard sauce.10. Serve with a sprig of fresh thyme and enjoy.",
                            Image = "HoneyMustardChicken.jpg",
                            Ingredients = "1 - 1 ¼ lbs. chicken breasts pounded and cut into 4-5 oz. portions, 2 Tbsp. Dijon mustard, 2 Tbsp. honey, 2 Tbsp. olive oil, ½ tsp. Worcestershire sauce, ¾ tsp. fresh thyme finely chopped, 1 clove garlic crushed, ½ tsp. salt to taste, ⅛ tsp. black pepper to taste, ⅛ tsp. paprika",
                            Name = "Honey Mustard Baked Chicken",
                            PrepTime = "10 Minutes",
                            Servings = 4,
                            TotalTime = "55 Minutes"
                        },
                        new
                        {
                            RecipeId = 9,
                            Author = "Julie's Eats and Treats",
                            CategoryId = "D",
                            Directions = "1. In a medium bowl mix the egg yolks with sugar using an electric mixer. Then add the milk and mix until it’s smooth and a light yellow color.2. Pour into a sauce pan and cook over medium heat, stirring constantly, until mixture boils. Boil gently for 1-2 minutes, remove from heat and allow to cool slightly. Cover tightly and chill in refrigerator for 1 hour.3. In a medium bowl, beat cream with vanilla and sugar until stiff peaks form. They peaks should stand when you stop whipping. Do not over mix.4. Remove yolk mixture from the fridge. Whisk mascarpone into the yolk mixture until smooth. Fold whipped cream into mixture.5. In a small bowl, combine coffee and rum. Dip the lady fingers into the mixture just long enough to get them wet, do not soak.6. Arrange half of the ladyfingers in the bottom of a 9x9 inch baking dish.7. Spoon half the mascarpone cream filling over the ladyfingers. Repeat layers.8. Cover and refrigerate at least 24 hours to let the flavors mix, but we would recommend 48 hours of chill time..9. Sprinkle with cocoa before serving.",
                            Image = "Tiramisu.jpg",
                            Ingredients = "6 egg yolks pasteurized (room temperature), ¾ c. white sugar, ⅔ c. milk, 1 ¼ c. heavy cream, 1 tsp vanilla extract, 1 Tbsp sugar, 1 lb mascarpone cheese room temperature, ½ c. espresso or strongly brewed, coffee room temperature, ¼ c. rum, 1 package ladyfinger cookies like Savoiardi 7 oz (about 28 ladyfingers total), 1 Tbsp unsweetened cocoa for dusting",
                            Name = "Tiramisu",
                            PrepTime = "45 Minutes",
                            Servings = 16,
                            TotalTime = "1d 45 Minutes"
                        },
                        new
                        {
                            RecipeId = 10,
                            Author = "Jessica Gavin",
                            CategoryId = "B",
                            Directions = "1. Pre-heat oven to 325°F.2. Mix the oats, nuts, seeds, melted oil, honey, vanilla, and cinnamon together in a bowl until thoroughly coated.3. Press about 3 tablespoons of the mixture into 8 greased mini tart pans. Use the back of an oiled spoon to help press the granola evenly across the pan and up the sides.4. Bake in the center rack of the oven for about 15 to 17 minutes, or until golden.5. Immediately after removing the tart shells from the oven, use the back of the spoon to press down the centers of the crust to create more of an indentation, and push up the sides. The shell puffs up in the oven, so it helps to reshape the crust after it bakes while still hot.6. Allow them to completely cool in the pan before removing.7. Use a small knife to gently release the sides of the crust, working around each side. Carefully remove them from the pan, turning over if needed into your hand. The crust should be crisp on the sides and hold together, but they will be very delicate.8. Fill each tart with 3 to 4 tablespoons yogurt and smooth it out evenly.9. Arrange the fruit on top and serve immediately. The crust will become soggy if left to sit for too long.",
                            Image = "Tart.jpg",
                            Ingredients = "1 ½ cups old fashioned oats, 1 cup walnuts, finely chopped, 1 tablespoon sesame seeds, 5 tablespoons coconut oil (melted), ¼ cup honey, 1 teaspoon vanilla extract, ½ teaspoon cinnamon (ground), 2 cups greek yogurt, 4 cups mixed fruit - for topping (strawberries, raspberries, blueberries, apples)",
                            Name = "Breakfast Fruit Tart with Granola Crust",
                            PrepTime = "20 Minutes",
                            Servings = 8,
                            TotalTime = " 35 Minutes"
                        },
                        new
                        {
                            RecipeId = 11,
                            Author = "Unicorns in the Kitchen",
                            CategoryId = "V",
                            Directions = "1. Preheat the oven to 375°F. IF you're using a pizza stone, place it in the oven.2. On a baking sheet or a pizza peel, roll out the pizza dough to 12 inches.3. Spread olive oil on the dough and sprinkle salt, thyme, black pepper and dried basil on the pizza dough.4. Top the pizza dough with artichoke hearts, sun-dried tomatoes, olives, red onion and fresh mozzarella. 5. Transfer the pizza onto the pizza stone (if using) and bake in the oven for about 15 to 18 minutes until cheese is melted and bubbly. 6. Top with fresh tomatoes and chopped parsley. 7. Serve immediately. ",
                            Image = "Pizza.jpg",
                            Ingredients = "1 12-inch pizza dough homemade or store-bought, 4 tbsp olive oil extra virgin, 1/2 tsp salt, 1 tsp thyme, 1/4 tsp black pepper, 1/2 tsp dried basil optional, 1 can artichoke hearts 15 oz, 3/4 cup sun-dried tomatoes, 1/2 cup kalamata olives pitted and halved, 3/4 cup red onion sliced, 1 cup fresh mozzarella sliced or shredded, 1/2 cup cherry tomatoes halved, 1/2 cup fresh parsley chopped",
                            Name = "The Best Mediterranean Pizza",
                            PrepTime = "15 Minutes",
                            Servings = 4,
                            TotalTime = "30 Minutes"
                        },
                        new
                        {
                            RecipeId = 12,
                            Author = "Cafe Delites",
                            CategoryId = "M",
                            Directions = "1. Mix together butter, garlic and fresh chopped parsley. Refrigerate until ready to use.2. Heat a large grill over high heat. Lightly grease grill plates with oil. Pat steaks dry with paper towel. Brush lightly with oil and generously season with salt and pepper.3. Grill steaks for 4-5 minutes each side until browned and cooked to desired doneness. Spread half of the butter all over of steaks. Transfer steaks to a warm plate and let rest for 5 minutes.4. While steaks are resting, melt remaining butter. Season shrimp with salt and pepper. 5. Reduce heat to medium and grill your shrimp for 5-6 minutes, depending not the size and thickness of your shrimp. Flip each one halfway through cook time and continue cooking until they turn nice and pink in colour while white and opaque on the inside.6. Toss remaining butter through shrimp and serve with steak!",
                            Image = "SteakShrimp.jpg",
                            Ingredients = "6 tablespoons unsalted butter divided, 4 cloves garlic (or 1 tablespoon minced garlic), 1 tablespoon fresh parsley (chopped), 1 tablespoon olive oil, 4 New York Steak strip steaks (Porterhouse steaks), Salt and pepper, 8 ounces (250 g) shrimp deveined",
                            Name = "Garlic Butter Grilled Steak & Shrimp",
                            PrepTime = "10 Minutes",
                            Servings = 4,
                            TotalTime = "25 Minutes"
                        },
                        new
                        {
                            RecipeId = 13,
                            Author = "JZ Eats",
                            CategoryId = "V",
                            Directions = "1. Preheat oven to 375 F.2. Add cherry tomatoes, 1/2 tablespoon olive oil, salt, and pepper to a 9 x 11 inch oven safe baking dish. Toss them in the pan to combine. Place peppers in the pan and bake for 10 minutes.3. While the tomatoes and peppers are cooking, heat 1 tbsp of olive oil over medium-high heat and sauté spinach, garlic, and onions until spinach has wilted. Drain the spinach well (I like to use a fine mesh strainer) and set aside in a mixing bowl.4. Add ricotta, red pepper flakes, egg, basil, and lemon zest to the mixing bowl with the spinach and mix until fully combined.5. Remove the peppers from the oven and stuff with the spinach and ricotta mixture. Top each pepper with about half a tablespoon of shredded parmesan cheese.6. Place the stuffed peppers in the oven and bake for about 5 minutes, just until the cheese on top has melted and the peppers are warm all the way through. Don't bake them too long or they will become watery inside!",
                            Image = "Peppers.jpg",
                            Ingredients = "4 bell peppers sliced in half lengthwise, 1/2 cup cherry tomatoes, 1 1/2 tablespoons olive oil, 4 cloves of garlic minced, 2 cups spinach, 1/2 yellow onion chopped, 25 ounces ricotta cheese drained*, 1/2 tablespoon red pepper flakes, 1 egg, 2 tablespoons fresh chopped basil, 1 lemon zest, parmesan cheese to taste",
                            Name = "Stuffed Peppers",
                            PrepTime = "10 Minutes",
                            Servings = 8,
                            TotalTime = "30 Minutes"
                        },
                        new
                        {
                            RecipeId = 14,
                            Author = "Salted Mint",
                            CategoryId = "V",
                            Directions = "1. Cook the pasta in plenty of salted boiling water according to the package instructions. Drain and reserve.2. To make the ricotta filling, place the ricotta, spinach nutmeg and salt and pepper in a medium boil and stir to combine with a fork. Stuff this mixture into the drained and cool shells. There should be enough filling for about 1 tablespoon of mixture per shell.3. To make the sauce, sweat the onions and garlic in a large pot and cook until the onions and garlic are soft and fragrant. Add the dried herbs and the passata or tomatoes and simmer for about 10 minutes. Place the sauce in the bottom of a pan and layer the stuffed shells over top. Generously sprinkle the cheese over the shells and bake until the whole dish is hot and the cheese is turning golden and starting to bubble.",
                            Image = "RicottaShells.jpg",
                            Ingredients = "20 large pasta shells, 10 oz frozen spinach thawed (excess water squeezed out), 1 1/2 cups low fat ricotta, Salt to taste, pinch of nutmeg, 2 cups grated mozzarella, 1 onion chopped, 2 cloves garlic grated, 2 cups passata or any think tomato sauce, 1 tablespoon dried oregano, 1 teaspoon dried thyme, 1 teaspoon dried rosemary",
                            Name = "Spinach & Ricotta Stuffed Shells",
                            PrepTime = "10 Minutes",
                            Servings = 8,
                            TotalTime = "30 Minutes"
                        },
                        new
                        {
                            RecipeId = 15,
                            Author = "FOOD52",
                            CategoryId = "D",
                            Directions = "1. Place 2/3 cup dark brown sugar, sifted cornstarch, espresso powder and salt in a bowl. Stir to combine. Set aside.2. In a medium-sized saucepan, heat the cream and milk on medium-low until just steaming.3. Stir the sugar mixture into the cream and continue mixing until sugar is dissolved, about 3 minutes.4. Increase heat to medium and continue stirring until milk/cream is very hot, but not boiling.5. While milk/cream is heating, in a medium bowl, whisk together the egg yolks and 1 tablespoon dark brown sugar.6. *Cook's Tip: Place a damp paper towel under your egg yolk bowl so it doesn't slip around the counter as you whisk.7. When milk/cream is very hot, take about a cupful and drizzle it into the egg mixture, all the while whisking the eggs like mad. This is called tempering the eggs, so you don't end up with scrambled eggs, which would be yucky in your pudding. Here's where the damp paper towel trick comes in handy.8. Pour the tempered egg mixture into the saucepan to join the pudding party. With the heat still at medium, stir continuously until really thick and pudding-y. About 7 minutes. Small bubbles are okay, but you don't want it to boil, so adjust the heat if necessary.9. Move the saucepan off the heat. Stir in the butter until melted. Stir in the vanilla.10. Let cool slightly and pour into small ramekins. You can choose to cover your pudding tops with plastic wrap - I choose not to. Chill for a few hours or serve slightly warm, with fresh cracked sea salt and a dollop of whipped cream.",
                            Image = "ButterscotchBudino.jpg",
                            Ingredients = "2/3 cup packed dark brown sugar plus 1 tablespoon, 2 tablespoons cornstarch sifted, 1 teaspoon espresso powder (optional), 1/4 teaspoon kosher salt, 3 large egg yolks (pull off any white bits with a little spoon), 1 cup heavy cream, 1 cup skim milk, 2 tablespoons unsalted butter (softened), 1 tablespoon vanilla extract, fresh cracked sea salt, whipped cream",
                            Name = "Butterscotch Budino",
                            PrepTime = "10 Minutes",
                            Servings = 4,
                            TotalTime = "3 Hours, 10 Minutes"
                        });
                });

            modelBuilder.Entity("RecipeApplication.Models.Recipe", b =>
                {
                    b.HasOne("RecipeApplication.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
