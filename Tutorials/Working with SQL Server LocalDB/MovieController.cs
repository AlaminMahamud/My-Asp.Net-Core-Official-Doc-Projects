public async Task<IActionResult> Edit(int? id)
{
    if(id==null)
    {
        return NotFound();
    }
    var movie = await context.Movie.SingleOrDefaultAsync(m=>m.Id == id);
    if(movie==null)
    {
        return NotFound();
    }
    return View(movie);
}