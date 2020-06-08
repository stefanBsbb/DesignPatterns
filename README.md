#Course project for design patterns using factory,state pattern,facade,bridge
#Project is a console app simulating shopping cart in a store.
#Project starts as of u are in a store and adding products to cart. 
#When user is done adding,he proceeds to if he wants to discard products,if he wants to, gets the ability to discard products based on input.
#After user is done adding/discarding , he has to select payment gateway,method and state tax.
#Based on method and tax,proceeding to orderdetails which gets our wallet and money we need to pay with tax.

#Factory initialized in Cart implementation with various interfaces,abstract classes
#-adding,discarding,products based on what state user is at

#State pattern initialized in State pattern folder,add,discard,payment state
#-add state(state that allows user to add products to cart)
#-discard state(state that allows user to discard products from cart)
#-payment state(user selects payment gateway and method to proceed to orderdetails)

#Facade pattern initialized in the Cart implementation
#-CheckProducts(gets product,checks if product is available,if(product is available) locks item)
#-PlaceOrder(gets wallet,Tax,address,orderdetails based on user input, calculates finalorder value,ends order)

#Bridge pattern is used for payment State
#-based on what gateway user has selected, he can select what method to use based on gateway , using bridge between gateway and method..