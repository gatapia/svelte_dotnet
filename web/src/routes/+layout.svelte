<script lang="ts">
	import '../app.scss';
	import {base} from '$app/paths';
	import {Header} from "carbon-components-svelte";
</script>

<svelte:head>
	<title>PicNet Svelte / .Net Project Template</title>
</svelte:head>

<main>
	<Header company="PicNet" platformName="Svelte / .Net Project Template">		
	</Header>
	<slot />
</main>

<footer>
</footer>
