/**
* <author>Dorian Fendrel</author>
* <url>lifxmod.com</url>
* <credits>PolankaMod</credits>
* <description>The Log Cart</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LogCart))
{
    new ScriptObject(LogCart)
    {
    };
}
package LogCart
{
  function LogCart::setup() {
	LiFx::registerCallback($LiFx::hooks::onDatablockLoad, RegisterTransportDatablock, LogCart);
    LiFx::registerCallback($LiFx::hooks::onMaterialsLoad, Registerdecmaterials, LogCart);
  }
	
  function LogCart::RegisterTransportDatablock() {
      LiFx::loadRecursivelyInFolder("yolauncher/modpack/mods/LiFx/LogCart", "Transport.cs");
  }

  function LogCart::Registerdecmaterials() {
    LiFx::loadRecursivelyInFolder("yolauncher/modpack/mods/LiFx/LogCart/textures", "LogCartMats.cs");
  }
  function LogCart::path() {
    return $Con::File;
  }
};
activatePackage(LogCart);
LiFx::registerCallback($LiFx::hooks::mods, setup, LogCart);