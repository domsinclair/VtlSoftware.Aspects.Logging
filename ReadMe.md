# VtlSoftware.Aspects.Logging

This packakage is a collection of aspects created with [Metalama](https://www.postsharp.net/metalama) that will allow you to easily add logging to a project or collection of projects in a solution.

It should be possible to use it with whichever Logging Framework is your framework of choice with the caveat that that framework support the ILogger interface provided by Microsoft.Extensions.Logging which in reality is the vast majority of them.

The package is open source and free to use.


## Using VtlSoftware.Aspects.Logging

After adding the package to your project you will need to configure a logging framework. Examples of how this can be done can be found in the package's help file which is available online.  There are also numerous examples of how this can be done to be found online.

Once that has been done then using it is as simple as adding an attribute to those properties or methods that you want to be logged.



### Provided Attributes

#### [Log]

Adds logging to a method.  Entry and Exit is logged along with details of any paramaeters that were passed into it.
If applicable the method's return value is also logged. In Addition this attribute can log properties.

#### [LogAndTime]

Exactly the same as the [LogMethod] attribute with the exception that the total duration that the method took to execute is also logged.
In Addition this attribute can log properties but will not time the interaction with the property.


#### [Redact]

This attribute will prevent sensitive parameters, or results, from being logged.  To be more precise rather that an actual value being recorded the word 'redacted' is substituted. Typical usage is as shown below.

```c#

//when redacting parameters do the following;

public bool ConfirmLogin(string userName, [Redact] string password)
{
	//Do stuff here.
}


// To redact a return then you need to apply the [Redact] attribute in the following way;

[LogMethod]
[return: Redact]
public string GetMyPassword()
{
      return "MySuperSafePassword";
}


```


#### [NoLog]

When applied to a Class, Method or Property no logging of that entity will occur.


### Fabric Extensions

A number of extion methods to provide Fabrics that will automate the process of adding logging attributes to your code base are also provided.  You can find more details on how to use those in the help file.


Current provided extensions are.

#### LogAllMethods

Applies the ```[Log]``` attribute to all eligible methods.

#### LogAndTimeAllMethods

Applies the ```[LogAndTime]``` attribute to all eligible methods.

#### LogAllPublicMethods

Applies the ```[Log]``` attribute to all public methods.

#### LogAndTimeAllPublicMethods

Applies the ```[LogAndTime]``` attribute to all public methods.

#### LogAllPublicAndPrivateMethods

Applies the ```[Log]``` attribute to all public and Private Methods.

#### LogAndTimeAllPublicAndPrivateMethods

Applies the ```[LogAndTime]``` attribute to all public and Private Methods.

#### LogEverything

Applies the ```[Log]``` attribute to all methods and the ```[Log]``` attribute to all properties.

#### TimeEveryMethodAndLogEveryProperty

Applies the ```[LogAndTime]``` attribute to all methods and the ```[LogAndTime]``` attribute to all properties.


## Help and Support

A comprehensive help file can be found [here](https://vtlsoftware.co.uk/aspectdocs/Introduction.html).

You may contact us at support at vtlsoftware dot co dot uk to ask questions or report any issues but you will probably find it quicker to report and issues on the github repo. 