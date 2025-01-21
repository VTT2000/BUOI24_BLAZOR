using System;
using System.Collections.Generic;

public class HTTPResponse<T> where T:class{
    public int statusCode{get;set;}
    public string message{get;set;}
    public T content{get;set;}
    public DateTime dataTime{get;set;}
    
}