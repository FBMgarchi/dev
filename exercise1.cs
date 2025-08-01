class Register {

    #region  Fields
    private int _address;
    private int _width;
    private string _name;
    public List<string> _bitFieldName;
    #endregion

    #region  Constructor
    public Register (string name, int address, int width){
        this._name = name;
        this._address = address;
        this._width = width;
    }
    #endregion

    public void ShowDetails()
    {
        Console.WriteLine($"Register details:\nName: {this._name}\nAddress: {this._address}\nWidth: {this._width}");        
    }

    public void AddBitField()
    {
        
    }
}