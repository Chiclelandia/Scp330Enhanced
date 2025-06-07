# Scp330Enhanced

**Scp330Enhanced** is a plugin for **SCP: Secret Laboratory**, built using the **EXILED** framework, aimed at expanding and improving the behavior of SCP-330.

This plugin currently provides full control over the **types of candies SCP-330 can offer**, allowing server administrators to **configure the spawn probability** of each individual candy. It also enables the use of the **pink candy**, which exists in the game but is disabled by default, letting you include it with a custom chance value.

The plugin is designed with extensibility in mind, laying the groundwork for more advanced control over SCP-330 and its interaction with rooms in future versions.

## Configuration

Default configuration is provided in the `config.yml` file, which can be found in the `Scp330Enhanced` folder within your server's `EXILED` plugins directory.
Something like `/server/.config/EXILED/Configs/Plugins/Scp330Enhanced/port.yml`

Default configuration:

```yaml
# Whether or not this plugin is enabled.
is_enabled: true
# Whether or not debug messages should be shown in the console.
debug: false
# List of allowed candies with their weights.
allowed_candies:
- candy: Rainbow
  weight: 16
- candy: Yellow
  weight: 16
- candy: Purple
  weight: 16
- candy: Red
  weight: 16
- candy: Green
  weight: 16
- candy: Blue
  weight: 16
- candy: Pink
  weight: 4

```