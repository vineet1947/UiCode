using UnityEngine;
using UnityEngine.UIElements;

public class Scrollview : MonoBehaviour
{

    public UIDocument Document;

    //Image myImage = new UnityEngine.UIElements.Image();
    //Sprite bugerSprite = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Resources/burger2.jpg"); 




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

    public SpriteRenderer bg;



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


        // ----------- Start Changing Here --------------------

        //buger 

        VisualElement burgerImage = new VisualElement();
        VisualElement lableBurger = new VisualElement();

        Label burgerLabel = new Label("Burger");

        //Texture2D blankTexture = new Texture2D(1024 , 1024 , TextureFormat.RGBA32 , true);
        //Sprite blankSprite = Sprite.Create(blankTexture, new Rect(0, 0, 1024, 1024), new Vector2(0.5f, 0.5f)); 

        //SpriteRenderer spriteRender = GetComponent<SpriteRenderer>(); 

        //spriteRender.sprite = blankSprite;



        //Rect rec = new Rect(0, 0, 60, 50); 
        //background-image: resource('burger');
        //Sprite.Create(sprites, rec, new Vector2(0, 0), 1);
        //bg.sprite = Sprite.Create(sprites, rec, new Vector2(0, 0), 0.1f);
        //sprites.Reinitialize(60, 50);
       // burgerImage.style.backgroundImage = Resources.Load<Texture2D>("Assets/Resources/coffee.jpg");




        // --------- End Here ----------------------------------

        burgerLabel.AddToClassList(textLabelStyle);
        burgerImage.AddToClassList(styleBurger);
        lableBurger.Add(burgerLabel);
        scrollView.Add(burgerImage);
        burgerImage.Add(burgerLabel);





        //offers 

        VisualElement offerImage = new VisualElement();
        VisualElement lableOffers = new VisualElement();

        Label offerLabel = new Label();

        offerLabel.text = "Offers";
        offerLabel.AddToClassList(textLabelStyle);
        offerImage.AddToClassList(styleoffers);
        lableOffers.Add(offerLabel);
        scrollView.Add(offerImage);

        offerImage.Add(offerLabel);

        // Asian  

        VisualElement asianImage = new VisualElement();
        VisualElement lableAsian = new VisualElement();

        Label asianLabel = new Label();
        asianLabel.text = "Asian";
        asianLabel.AddToClassList(textLabelStyle);
        asianImage.AddToClassList(styleAsian);
        lableAsian.Add(asianLabel);
        scrollView.Add(asianImage);

        asianImage.Add(asianLabel);


        // pizza 
        VisualElement pizzaImage = new VisualElement();
        VisualElement lablePizza = new VisualElement();

        Label pizzaLabel = new Label();

        pizzaLabel.text = "Pizza";
        pizzaLabel.AddToClassList(textLabelStyle);
        pizzaImage.AddToClassList(stylePizza);
        lablePizza.Add(pizzaLabel);
        scrollView.Add(pizzaImage);
        pizzaImage.Add(pizzaLabel);


        // cupcake  
        VisualElement cupcakeImage = new VisualElement();
        VisualElement lableCupcake = new VisualElement();
        Label capcakeLabel = new Label();
        capcakeLabel.text = "CupCake";
        capcakeLabel.AddToClassList(textLabelStyle);
        cupcakeImage.AddToClassList(styleCupcake);
        lableCupcake.Add(capcakeLabel);
        scrollView.Add(cupcakeImage);
        cupcakeImage.Add(capcakeLabel);



        //sandwich 
        VisualElement sandwichImage = new VisualElement();
        VisualElement lableSandwich = new VisualElement();
        Label sandwichLabel = new Label();
        sandwichLabel.text = "Sandwich";
        sandwichLabel.AddToClassList(textLabelStyle);
        sandwichImage.AddToClassList(styleSandwich);
        lableSandwich.Add(sandwichLabel);
        scrollView.Add(sandwichImage);
        sandwichImage.Add(sandwichLabel);


        //Bottom visual element

        var bottom = root.Q<VisualElement>("bottomElement");


        // VisualElement bottomElement = new VisualElement(); 
        //bottomElement.AddToClassList(textBottomStyle);


        Label bottomLabel = new Label(" Hello Vineet sdkuvsdkcskcnskncsdnlckdc csdhcvsjccs");

        bottomLabel.AddToClassList(textBottomStyle);
        //   bottomLabel.text = " Hello Vineet sdkuvsdkcskcnskncsdnlckdc csdhcvsjccs";


        bottom.Add(bottomLabel);



    }
}

