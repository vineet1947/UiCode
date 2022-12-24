using UnityEngine;
using UnityEngine.UIElements;

public class Scrollview : MonoBehaviour
{

    public UIDocument Document;

    
    // USS strings  for uss class selectors   

    private const string textLabelStyle = "textStyle";

    private const string textBottomStyle = "bottom-label-text";

    private const string stylePasta = "pasta";
    private const string styleBurger = "burger";
    private const string styleoffers = "offers";
    private const string styleAsian = "asian";
    private const string stylePizza = "pizza";
    private const string styleCupcake = "cupcake";
    private const string styleSandwich = "sandwich";


    private void Awake()
    {
        VisualElement root = Document.rootVisualElement;
        var scrollView = root.Q("horizontal");

        // Pasta 

        VisualElement pastaImage = new VisualElement(); // make a visual element for image
        VisualElement lablePasta = new VisualElement();  // make a visual element for lable text 

        Label pastaLabel = new Label(); // new lable to be added ==> as visual elements are not having any text property 

        pastaLabel.text = "Pasta"; // setting text
        pastaLabel.AddToClassList(textLabelStyle); // adding uss to pasta lable visual element                           
        pastaImage.AddToClassList(stylePasta); //adding uss to make it visible  
        lablePasta.Add(pastaLabel); // adding lable to pasta image  visual element  
        scrollView.Add(pastaImage);   // adding element to scrolling conatiner  

        pastaImage.Add(pastaLabel);


        //burger 

        VisualElement burgerImage = new VisualElement();
        VisualElement lableBurger = new VisualElement();

        Label burgerLabel = new Label("Burger");


        string burgerFile = "Assets/Resources/burger.jpg"; // load images from anywhere !! 
        var rawDataBuger = System.IO.File.ReadAllBytes(burgerFile);
        Texture2D texBurger = new Texture2D(2, 2); // Create an empty Texture; size doesn't matter 
        texBurger.LoadImage(rawDataBuger);
        burgerImage.style.backgroundImage = texBurger;

        //adding uss ==> 
        burgerLabel.AddToClassList(textLabelStyle);
        burgerImage.AddToClassList(styleBurger);
        lableBurger.Add(burgerLabel);
        scrollView.Add(burgerImage);
        burgerImage.Add(burgerLabel);


        //offers 

        VisualElement offerImage = new VisualElement();
        VisualElement lableOffers = new VisualElement();

        Label offerLabel = new Label();

        string offerFile = "Assets/Resources/offers.png"; // load images from anywhere !! 
        var rawDataOffer = System.IO.File.ReadAllBytes(offerFile);
        Texture2D texOffer = new Texture2D(2, 2); // Create an empty Texture; size doesn't matter 
        texOffer.LoadImage(rawDataOffer);

        offerImage.style.backgroundImage = texOffer;



        offerLabel.text = "Offers";
        offerLabel.AddToClassList(textLabelStyle);
        offerImage.AddToClassList(styleoffers);
        lableOffers.Add(offerLabel);
        scrollView.Add(offerImage);

        offerImage.Add(offerLabel);

        // Asian  

        VisualElement asianImage = new VisualElement();
        VisualElement lableAsian = new VisualElement();

        Label asianLabel = new Label("Asian");

        string asianFile = "Assets/Resources/asian.png"; // load images from anywhere !! 
        var rawDataAsian = System.IO.File.ReadAllBytes(asianFile);
        Texture2D texAsian = new Texture2D(2, 2); // Create an empty Texture; size doesn't matter 
        texAsian.LoadImage(rawDataAsian);

        asianImage.style.backgroundImage = texAsian;



        asianLabel.AddToClassList(textLabelStyle);
        asianImage.AddToClassList(styleAsian);
        lableAsian.Add(asianLabel);
        scrollView.Add(asianImage);

        asianImage.Add(asianLabel);


        // pizza 
        VisualElement pizzaImage = new VisualElement();
        VisualElement lablePizza = new VisualElement();

        Label pizzaLabel = new Label("Pizza");


        string pizzaFile = "Assets/Resources/pizza.jpg"; // load images from anywhere !! 
        var rawDataPizza = System.IO.File.ReadAllBytes(pizzaFile);
        Texture2D texPizza = new Texture2D(2, 2); // Create an empty Texture; size doesn't matter 
        texPizza.LoadImage(rawDataPizza);

        pizzaImage.style.backgroundImage = texPizza;




        pizzaLabel.AddToClassList(textLabelStyle);
        pizzaImage.AddToClassList(stylePizza);
        lablePizza.Add(pizzaLabel);
        scrollView.Add(pizzaImage);
        pizzaImage.Add(pizzaLabel);


        // cupcake  
        VisualElement cupcakeImage = new VisualElement();
        VisualElement lableCupcake = new VisualElement();
        Label capcakeLabel = new Label("CupCake");


        // adding image ==>
        string cupFile = "Assets/Resources/cupcake.jpg"; // load images from anywhere !! 
        var rawDataCup = System.IO.File.ReadAllBytes(cupFile);
        Texture2D texCup = new Texture2D(2, 2); // Create an empty Texture; size doesn't matter 
        texCup.LoadImage(rawDataCup);

        cupcakeImage.style.backgroundImage = texCup;

        // adding uss ==>
        capcakeLabel.AddToClassList(textLabelStyle);
        cupcakeImage.AddToClassList(styleCupcake);
        lableCupcake.Add(capcakeLabel);
        scrollView.Add(cupcakeImage);
        cupcakeImage.Add(capcakeLabel);



        //sandwich 
        VisualElement sandwichImage = new VisualElement();
        VisualElement lableSandwich = new VisualElement();
        Label sandwichLabel = new Label("Sandwich");

        //adding images ==>
        string sandFile = "Assets/Resources/sandwich.jpg"; // load images from anywhere !! 
        var rawDataSand = System.IO.File.ReadAllBytes(sandFile);
        Texture2D texSand = new Texture2D(2, 2); // Create an empty Texture; size doesn't matter 
        texSand.LoadImage(rawDataSand);

        sandwichImage.style.backgroundImage = texSand;

        // adding uss ==>

        sandwichLabel.AddToClassList(textLabelStyle);
        sandwichImage.AddToClassList(styleSandwich);
        lableSandwich.Add(sandwichLabel);
        scrollView.Add(sandwichImage);
        sandwichImage.Add(sandwichLabel);


        //Bottom visual element

        var bottom = root.Q<VisualElement>("bottomElement");

        Label bottomLabel = new Label(" Hello Vineet sdkuvsdkcskcnskncsdnlckdc csdhcvsjccs");
        bottomLabel.AddToClassList(textBottomStyle);
        bottom.Add(bottomLabel);
    }
}

