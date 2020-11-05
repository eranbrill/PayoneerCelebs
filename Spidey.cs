public Class Spiderman {
  private Power _power;
  private Responsiblity _resposiblity; 

  public  Spiderman (Power power, ResposnibilityFactory resposibilityFactory) {
    this._power = power;
    if  ("Great" == Power.Level) {
        this._resposibility= resposibilityFactory.Great();
      }
  }
  
  // Spidy is already coding for us
  // Click the link bellow if you want to join a great team and do great stuff together (not sure about saving the world)
  
}
 
  
  

  
