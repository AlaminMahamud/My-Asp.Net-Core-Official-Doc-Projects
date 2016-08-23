[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Edit(int id, [Bind("Id,Genre,Price,ReleaseDate,Title")] Movie movie)
{
    if(id != movie.Id)
    {
        return NotFound();
    }
    try
    {
        context.Update(movie);
        await context.SaveChangesAsync();
    }
    catch(DatabaseConcurrencException ex)
    {
        if(!MovieExists(movie.Id))
        {
            return NotFound();
        }else
        {
            throw;
        }
        return RedirectToAction("Index");
    }
    return View(movie);
}