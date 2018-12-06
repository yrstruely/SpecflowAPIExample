# SpecflowAPIExample

This is an example project demonstrating API testing using: Specflow, NUnit, RestSharp, and RestClient.

### Features

* Behaviour Driven RestAPI Testing with POCO Deserialization
* Caching
* Error Logging
* Timeout checking and Error Logging
* Automatic XML and JSON deserialization
* Supports custom serialization and deserialization via ISerializer and IDeserializer
* Fuzzy element name matching ('product_id' in XML/JSON will match C# property named 'ProductId')
* Automatic detection of type of content returned
* GET, POST, PUT, PATCH, HEAD, OPTIONS, DELETE, COPY supported
* Other non-standard HTTP methods also supported
* OAuth 1, OAuth 2, Basic, NTLM and Parameter-based Authenticators included
* Supports custom authentication schemes via IAuthenticator
* Multi-part form/file uploads
