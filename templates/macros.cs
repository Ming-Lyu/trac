<?cs def:hdf_select(enum, name, selected) ?>
  <select size="1" name="<?cs var:name ?>">
  <?cs each:item = $enum ?>
    <?cs if item.name == $selected ?>
      <option selected><?cs var:item.name ?></option>
    <?cs else ?>
      <option><?cs var:item.name ?></option>
    <?cs /if ?>
  <?cs /each ?>
  </select>
<?cs /def?>

