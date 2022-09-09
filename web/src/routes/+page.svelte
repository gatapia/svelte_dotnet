<script lang="ts">
  import {Content, Grid, Row, Column} from "carbon-components-svelte";
	import {ApiServer} from '$lib/apiserver';

  let label: string = '';

  async function ping() {
    const res = await ApiServer.get('demo');
    label = res.result;
  }
</script>
<Content>
  <Grid>
    <Row>
      <Column>
        <button on:click={() => ping()}>Click to test endpoint</button>
        <span>{label}</span>
      </Column>
    </Row>
  </Grid>
</Content>
