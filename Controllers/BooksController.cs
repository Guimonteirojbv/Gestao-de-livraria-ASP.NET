using Gestão_de_Livraria.Communication.Request;
using Gestão_de_Livraria.Communication.Response;

using Microsoft.AspNetCore.Mvc;

namespace Gestão_de_Livraria.Controllers;

public class BooksController : BooksApiBase
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseGetBookJson), StatusCodes.Status200OK)]
    public IActionResult Get([FromRoute] int id)
    {
        var database = Database.Instance;

        var livro = database.GetBook(id);

        return Ok(livro);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult CreateBook([FromBody] Book request)
    {
        var database = Database.Instance;

        database.CreateBook(request);


        return Created();
    }

    [HttpGet("get-all-books")]
    [ProducesResponseType(typeof(Dictionary< int, ResponseGetBookJson>), StatusCodes.Status200OK)]

    public IActionResult GetAll()
    {
        var database = Database.Instance;

        var books = database.GetAllBooks();
    
        return Ok(books);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]

    public IActionResult DeleteBook([FromRoute] int id)
    {
        var database = Database.Instance;

        database.DeleteBook(id);

        return NoContent();
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]

    public IActionResult Update([FromRoute] int id, [FromBody] Book book)
    {
        var database = Database.Instance;

        database.UpdateBook(id, book);

        return NoContent();
    }
    

}
