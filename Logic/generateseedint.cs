



<!DOCTYPE html>
<html lang="en-US" >

<head>

	
	<script>
window.ts_endpoint_url = "https:\/\/slack.com\/beacon\/timing";

(function(e) {
	var n=Date.now?Date.now():+new Date,r=e.performance||{},t=[],a={},i=function(e,n){for(var r=0,a=t.length,i=[];a>r;r++)t[r][e]==n&&i.push(t[r]);return i},o=function(e,n){for(var r,a=t.length;a--;)r=t[a],r.entryType!=e||void 0!==n&&r.name!=n||t.splice(a,1)};r.now||(r.now=r.webkitNow||r.mozNow||r.msNow||function(){return(Date.now?Date.now():+new Date)-n}),r.mark||(r.mark=r.webkitMark||function(e){var n={name:e,entryType:"mark",startTime:r.now(),duration:0};t.push(n),a[e]=n}),r.measure||(r.measure=r.webkitMeasure||function(e,n,r){n=a[n].startTime,r=a[r].startTime,t.push({name:e,entryType:"measure",startTime:n,duration:r-n})}),r.getEntriesByType||(r.getEntriesByType=r.webkitGetEntriesByType||function(e){return i("entryType",e)}),r.getEntriesByName||(r.getEntriesByName=r.webkitGetEntriesByName||function(e){return i("name",e)}),r.clearMarks||(r.clearMarks=r.webkitClearMarks||function(e){o("mark",e)}),r.clearMeasures||(r.clearMeasures=r.webkitClearMeasures||function(e){o("measure",e)}),e.performance=r,"function"==typeof define&&(define.amd||define.ajs)&&define("performance",[],function(){return r}) // eslint-disable-line
})(window);

</script>
<script>


;(function() {



window.TSMark = function(mark_label) {
	if (!window.performance || !window.performance.mark) return;
	performance.mark(mark_label);
};
window.TSMark('start_load');


window.TSMeasureAndBeacon = function(measure_label, start_mark_label) {
	if (start_mark_label === 'start_nav' && window.performance && window.performance.timing) {
		window.TSBeacon(measure_label, (new Date()).getTime() - performance.timing.navigationStart);
		return;
	}
	if (!window.performance || !window.performance.mark || !window.performance.measure) return;
	performance.mark(start_mark_label + '_end');
	try {
		performance.measure(measure_label, start_mark_label, start_mark_label + '_end');
		window.TSBeacon(measure_label, performance.getEntriesByName(measure_label)[0].duration);
	} catch (e) {
		
	}
};


if ('sendBeacon' in navigator) {
	window.TSBeacon = function(label, value) {
		var endpoint_url = window.ts_endpoint_url || 'https://slack.com/beacon/timing';
		navigator.sendBeacon(endpoint_url + '?data=' + encodeURIComponent(label + ':' + value), '');
	};
} else {
	window.TSBeacon = function(label, value) {
		var endpoint_url = window.ts_endpoint_url || 'https://slack.com/beacon/timing';
		(new Image()).src = endpoint_url + '?data=' + encodeURIComponent(label + ':' + value);
	};
}
})();
</script>
 

<script>
window.TSMark('step_load');
</script>	<noscript><meta http-equiv="refresh" content="0; URL=/files/U4KRJPX98/F6YBQU7C3/generateseedint.cs?nojsmode=1" /></noscript>
<script type="text/javascript">
if(self!==top)window.document.write("\u003Cstyle>body * {display:none !important;}\u003C\/style>\u003Ca href=\"#\" onclick="+
"\"top.location.href=window.location.href\" style=\"display:block !important;padding:10px\">Go to Slack.com\u003C\/a>");

(function() {
	var timer;
	if (self !== top) {
		timer = window.setInterval(function() {
			if (window.$) {
				try {
					$('#page').remove();
					$('#client-ui').remove();
					window.TS = null;
					window.clearInterval(timer);
				} catch(e) {}
			}
		}, 200);
	}
}());

</script>

<script>

(function() {


	window.callSlackAPIUnauthed = function(method, args, callback) {
		var timestamp = Date.now() / 1000;  
		var version = (window.TS && TS.boot_data && TS.boot_data.version_uid) ? TS.boot_data.version_uid.substring(0, 8) : 'noversion';
		var url = '/api/' + method + '?_x_id=' + version + '-' + timestamp;

		var req = new XMLHttpRequest();

		req.onreadystatechange = function() {
			if (req.readyState == 4) {
				req.onreadystatechange = null;
				var obj;

				if (req.status == 200 || req.status == 429) {
					try {
						obj = JSON.parse(req.responseText);
					} catch (err) {
						TS.warn(8675309, 'unable to do anything with api rsp');
					}
				}

				obj = obj || {
					ok: false,
				};

				callback(obj.ok, obj, args);
			}
		};

		var async = true;
		req.open('POST', url, async);

		var form_data = new FormData();
		var has_data = false;
		Object.keys(args).forEach(function(k) {
			if (k[0] === '_') return;
			form_data.append(k, args[k]);
			has_data = true;
		});

		if (has_data) {
			req.send(form_data);
		} else {
			req.send();
		}
	};
})();
</script>

	<script type="text/javascript" src="https://a.slack-edge.com/bv1-1/webpack.manifest.d66bb9b7cb31b4a9afc3.min.js" crossorigin="anonymous" onload="window._cdn && _cdn.ok(this, arguments)" onerror="window._cdn && _cdn.failed(this, arguments)"></script>

			
	
		<script>
			if (window.location.host == 'slack.com' && window.location.search.indexOf('story') < 0) {
				document.cookie = '__cvo_skip_doc=' + escape(document.URL) + '|' + escape(document.referrer) + ';path=/';
			}
		</script>
	

		<script type="text/javascript">
		
		try {
			if(window.location.hash && !window.location.hash.match(/^(#?[a-zA-Z0-9_]*)$/)) {
				window.location.hash = '';
			}
		} catch(e) {}
		
	</script>

	<script type="text/javascript">
				
			window.optimizely = [];
			window.dataLayer = [];
			window.ga = false;
		
	
				(function(e,c,b,f,d,g,a){e.SlackBeaconObject=d;
		e[d]=e[d]||function(){(e[d].q=e[d].q||[]).push([1*new Date(),arguments])};
		e[d].l=1*new Date();g=c.createElement(b);a=c.getElementsByTagName(b)[0];
		g.async=1;g.src=f;a.parentNode.insertBefore(g,a)
		})(window,document,"script","https://a.slack-edge.com/bv1-1/slack_beacon.5dbbc3dd9f37d8bc2f4e.min.js","sb");
		sb('set', 'token', '3307f436963e02d4f9eb85ce5159744c');

					sb('set', 'user_id', "U4KRJPX98");
							sb('set', 'user_' + "batch", "signup_api");
							sb('set', 'user_' + "created", "2017-03-17");
						sb('set', 'name_tag', "playmakertalk" + '/' + "tcmeric");
				sb('track', 'pageview');

		
		function track(a) {
			if(window.ga) ga('send','event','web', a);
			if(window.sb) sb('track', a);
		}
		

	</script>

	

	<meta name="referrer" content="no-referrer">
		<meta name="superfish" content="nofish">

	<script type="text/javascript">



var TS_last_log_date = null;
var TSMakeLogDate = function() {
	var date = new Date();

	var y = date.getFullYear();
	var mo = date.getMonth()+1;
	var d = date.getDate();

	var time = {
	  h: date.getHours(),
	  mi: date.getMinutes(),
	  s: date.getSeconds(),
	  ms: date.getMilliseconds()
	};

	Object.keys(time).map(function(moment, index) {
		if (moment == 'ms') {
			if (time[moment] < 10) {
				time[moment] = time[moment]+'00';
			} else if (time[moment] < 100) {
				time[moment] = time[moment]+'0';
			}
		} else if (time[moment] < 10) {
			time[moment] = '0' + time[moment];
		}
	});

	var str = y + '/' + mo + '/' + d + ' ' + time.h + ':' + time.mi + ':' + time.s + '.' + time.ms;
	if (TS_last_log_date) {
		var diff = date-TS_last_log_date;
		//str+= ' ('+diff+'ms)';
	}
	TS_last_log_date = date;
	return str+' ';
}

var parseDeepLinkRequest = function(code) {
	var m = code.match(/"id":"([CDG][A-Z0-9]{8})"/);
	var id = m ? m[1] : null;

	m = code.match(/"team":"(T[A-Z0-9]{8})"/);
	var team = m ? m[1] : null;

	m = code.match(/"message":"([0-9]+\.[0-9]+)"/);
	var message = m ? m[1] : null;

	return { id: id, team: team, message: message };
}

if ('rendererEvalAsync' in window) {
	var origRendererEvalAsync = window.rendererEvalAsync;
	window.rendererEvalAsync = function(blob) {
		try {
			var data = JSON.parse(decodeURIComponent(atob(blob)));
			if (data.code.match(/handleDeepLink/)) {
				var request = parseDeepLinkRequest(data.code);
				if (!request.id || !request.team || !request.message) return;

				request.cmd = 'channel';
				TSSSB.handleDeepLinkWithArgs(JSON.stringify(request));
				return;
			} else {
				origRendererEvalAsync(blob);
			}
		} catch (e) {
		}
	}
}
</script>



<script type="text/javascript">

	var TSSSB = {
		call: function() {
			return false;
		}
	};

</script>
<script>TSSSB.env = (function() {


	var v = {
		win_ssb_version: null,
		win_ssb_version_minor: null,
		mac_ssb_version: null,
		mac_ssb_version_minor: null,
		mac_ssb_build: null,
		lin_ssb_version: null,
		lin_ssb_version_minor: null,
		desktop_app_version: null,
	};

	var is_win = (navigator.appVersion.indexOf('Windows') !== -1);
	var is_lin = (navigator.appVersion.indexOf('Linux') !== -1);
	var is_mac = !!(navigator.userAgent.match(/(OS X)/g));

	if (navigator.userAgent.match(/(Slack_SSB)/g) || navigator.userAgent.match(/(Slack_WINSSB)/g)) {
		
		var parts = navigator.userAgent.split('/');
		var version_str = parts[parts.length - 1];
		var version_float = parseFloat(version_str);
		var version_parts = version_str.split('.');
		var version_minor = (version_parts.length == 3) ? parseInt(version_parts[2], 10) : 0;

		if (navigator.userAgent.match(/(AtomShell)/g)) {
			
			if (is_lin) {
				v.lin_ssb_version = version_float;
				v.lin_ssb_version_minor = version_minor;
			} else if (is_win) {
				v.win_ssb_version = version_float;
				v.win_ssb_version_minor = version_minor;
			} else if (is_mac) {
				v.mac_ssb_version = version_float;
				v.mac_ssb_version_minor = version_minor;
			}

			if (version_parts.length >= 3) {
				v.desktop_app_version = {
					major: parseInt(version_parts[0], 10),
					minor: parseInt(version_parts[1], 10),
					patch: parseInt(version_parts[2], 10),
				};
			}
		}
	}

	return v;
})();
</script>


	<script type="text/javascript">
		
		window.addEventListener('load', function() {
			var was_TS = window.TS;
			delete window.TS;
			if (was_TS) window.TS = was_TS;
		});
	</script>
	        <title>GenerateSeedInt.cs | Playmaker Slack</title>
    <meta name="author" content="Slack">
        

	
		
	
	
		
					
	
						
	
	

	
	
	
	
	
	
	
		<!-- output_css "sk_adapter" -->
    <link href="https://a.slack-edge.com/1c122/style/rollup-slack_kit_legacy_adapters.css" rel="stylesheet" type="text/css" crossorigin="anonymous" onload="window._cdn && _cdn.ok(this, arguments)" onerror="window._cdn && _cdn.failed(this, arguments)">

			<!-- output_css "core" -->
    <link href="https://a.slack-edge.com/a3fd/style/rollup-plastic.css" rel="stylesheet" type="text/css" crossorigin="anonymous" onload="window._cdn && _cdn.ok(this, arguments)" onerror="window._cdn && _cdn.failed(this, arguments)">

		<!-- output_css "before_file_pages" -->
    <link href="https://a.slack-edge.com/74a30/style/libs/codemirror.css" rel="stylesheet" type="text/css" crossorigin="anonymous" onload="window._cdn && _cdn.ok(this, arguments)" onerror="window._cdn && _cdn.failed(this, arguments)">
    <link href="https://a.slack-edge.com/9f66f/style/codemirror_overrides.css" rel="stylesheet" type="text/css" crossorigin="anonymous" onload="window._cdn && _cdn.ok(this, arguments)" onerror="window._cdn && _cdn.failed(this, arguments)">

	<!-- output_css "file_pages" -->
    <link href="https://a.slack-edge.com/33612/style/rollup-file_pages.css" rel="stylesheet" type="text/css" crossorigin="anonymous" onload="window._cdn && _cdn.ok(this, arguments)" onerror="window._cdn && _cdn.failed(this, arguments)">

	
			<!-- output_css "slack_kit_helpers" -->
    <link href="https://a.slack-edge.com/5cc7/style/rollup-slack_kit_helpers.css" rel="stylesheet" type="text/css" id="slack_kit_helpers_stylesheet"  crossorigin="anonymous" onload="window._cdn && _cdn.ok(this, arguments)" onerror="window._cdn && _cdn.failed(this, arguments)">

	<!-- output_css "regular" -->
    <link href="https://a.slack-edge.com/bb9b5/style/print.css" rel="stylesheet" type="text/css" crossorigin="anonymous" onload="window._cdn && _cdn.ok(this, arguments)" onerror="window._cdn && _cdn.failed(this, arguments)">
    <link href="https://a.slack-edge.com/5e83b/style/libs/lato-2-compressed.css" rel="stylesheet" type="text/css" crossorigin="anonymous" onload="window._cdn && _cdn.ok(this, arguments)" onerror="window._cdn && _cdn.failed(this, arguments)">

	

	
	
		<meta name="robots" content="noindex, nofollow" />
	

	
<link id="favicon" rel="shortcut icon" href="https://a.slack-edge.com/436da/marketing/img/meta/favicon-32.png" sizes="16x16 32x32 48x48" type="image/png" />

<link rel="icon" href="https://a.slack-edge.com/436da/marketing/img/meta/app-256.png" sizes="256x256" type="image/png" />

<link rel="apple-touch-icon-precomposed" sizes="152x152" href="https://a.slack-edge.com/436da/marketing/img/meta/ios-152.png" />
<link rel="apple-touch-icon-precomposed" sizes="144x144" href="https://a.slack-edge.com/436da/marketing/img/meta/ios-144.png" />
<link rel="apple-touch-icon-precomposed" sizes="120x120" href="https://a.slack-edge.com/436da/marketing/img/meta/ios-120.png" />
<link rel="apple-touch-icon-precomposed" sizes="114x114" href="https://a.slack-edge.com/436da/marketing/img/meta/ios-114.png" />
<link rel="apple-touch-icon-precomposed" sizes="72x72" href="https://a.slack-edge.com/436da/marketing/img/meta/ios-72.png" />
<link rel="apple-touch-icon-precomposed" href="https://a.slack-edge.com/436da/marketing/img/meta/ios-57.png" />

<meta name="msapplication-TileColor" content="#FFFFFF" />
<meta name="msapplication-TileImage" content="https://a.slack-edge.com/436da/marketing/img/meta/app-144.png" />
	
</head>

<body class="				">

		  			<script>
		
			var w = Math.max(document.documentElement.clientWidth, window.innerWidth || 0);
			if (w > 1440) document.querySelector('body').classList.add('widescreen');
		
		</script>
	
  	
	
	

			

<nav id="site_nav" class="no_transition">

	<div id="site_nav_contents">

		<div id="user_menu">
			<div id="user_menu_contents">
				<div id="user_menu_avatar">
										<span class="member_image thumb_48" style="background-image: url('https://avatars.slack-edge.com/2017-03-17/156576633431_72257b76199013178457_192.png')" data-thumb-size="48" data-member-id="U4KRJPX98"></span>
					<span class="member_image thumb_36" style="background-image: url('https://avatars.slack-edge.com/2017-03-17/156576633431_72257b76199013178457_72.png')" data-thumb-size="36" data-member-id="U4KRJPX98"></span>
				</div>
				<h3>Signed in as</h3>
				<span id="user_menu_name">tcmeric</span>
			</div>
		</div>

		<div class="nav_contents">

			<ul class="primary_nav">
									<li><a href="/messages" data-qa="app"><i class="ts_icon ts_icon_angle_arrow_up_left"></i>Back to Slack</a></li>
								<li><a href="/home" data-qa="home"><i class="ts_icon ts_icon_home"></i>Home</a></li>
				<li><a href="/account" data-qa="account_profile"><i class="ts_icon ts_icon_user"></i>Account &amp; Profile</a></li>
				<li><a href="/apps/manage" data-qa="configure_apps" target="_blank"><i class="ts_icon ts_icon_plug"></i>Configure Apps</a></li>
									<li><a href="/files" data-qa="files"><i class="ts_icon ts_icon_all_files clear_blue"></i>Files</a></li>
				
														<li><a href="/stats" data-qa="statistics"><i class="ts_icon ts_icon_dashboard"></i>Analytics</a></li>
													<li><a href="/customize" data-qa="customize"><i class="ts_icon ts_icon_magic"></i>Customize</a></li>
											</ul>

							<h3>Administration</h3>
				<ul id="admin_nav" class="secondary_nav">
											<li><a href="/admin/settings" data-qa="team_settings">Settings &amp; Permissions</a></li>
						<li><a href="/admin" data-qa="manage_your_team">Manage Workspace</a></li>
						<li><a href="/admin/invites" data-qa="invitations">Invitations</a></li>
																<li><a href="/admin/billing?ui_element=15&ui_step=27" data-qa="billing" data-clog-event="WEBSITE_CLICK" data-clog-params="action=click,click_target=billing_nav,trigger=inc_nav,pay_prod_cur=,has_plan=true">Billing</a></li>
																									<li><a href="/admin/auth" data-qa="authentication">Authentication</a></li>
															</ul>
			
		</div>

		<div id="footer">

			<ul id="footer_nav">
				<li><a href="/is" data-qa="tour">Tour</a></li>
				<li><a href="/downloads" data-qa="download_apps">Download Apps</a></li>
				<li><a href="/brand-guidelines" data-qa="brand_guidelines">Brand Guidelines</a></li>
				<li><a href="/help" data-qa="help">Help</a></li>
				<li><a href="https://api.slack.com" target="_blank" data-qa="api">API<i class="ts_icon ts_icon_external_link small_left_margin ts_icon_inherit"></i></a></li>
									<li><a href="/account/gateways" data-qa="gateways">Gateways</a></li>
								<li><a href="/pricing?ui_step=96&ui_element=5" data-qa="pricing" data-clog-event="GROWTH_PRICING" data-clog-ui-element="pricing_link" data-clog-ui-action="click" data-clog-ui-step="admin_footer">Pricing</a></li>
				<li><a href="/help/requests/new" data-qa="contact">Contact</a></li>
				<li><a href="/terms-of-service" data-qa="policies">Policies</a></li>
				<li><a href="https://slackhq.com/" target="_blank" data-qa="our_blog">Our Blog</a></li>
				<li><a href="https://slack.com/signout/155191149137?crumb=s-1523196698-fc99e9fb444cc1d425c0ad3029aa6bc5586d0c9ac6a8bae596e20a3b2070caad-%E2%98%83" data-qa="sign_out">Sign Out<i class="ts_icon ts_icon_sign_out small_left_margin ts_icon_inherit"></i></a></li>
			</ul>

			<p id="footer_signature">Made with <i class="ts_icon ts_icon_heart"></i> by Slack</p>

		</div>

	</div>
</nav>	
			
<header>
			<a id="menu_toggle" class="no_transition" data-qa="menu_toggle_hamburger">
			<span class="menu_icon"></span>
			<span class="menu_label">Menu</span>
			<span class="vert_divider"></span>
		</a>
		<h1 id="header_team_name" class="inline_block no_transition" data-qa="header_team_name">
			<a href="/home">
				<i class="ts_icon ts_icon_home"></i>
				Playmaker
			</a>
		</h1>
		<div class="header_nav">
			<div class="header_btns float_right">
				<a href="" onclick="return false;" id="plans_switcher" data-qa="plans_switcher">
					<i class="ts_icon ts_icon_rocket ts_icon_inherit"></i>
					<span class="block label">Plans</span>
				</a>

				<ul id="header_plans_nav" data-qa="plans_switcher_menu">
					<li class="plans_switcher_item "><a data-clog-event="UPGRDEXP_PLANS_IN_TEAM_NAV" data-clog-ui-element="learn_more_standard" data-clog-ui-action="click" data-clog-ui-step="TEAM_NAV_PLANS_MENU"href="https://slack.com/pricing/standard?ui_element=53&ui_step=222">
												<span class="switcher_label">Standard</span>
					</a></li>
					<li class="plans_switcher_item "><a data-clog-event="UPGRDEXP_PLANS_IN_TEAM_NAV" data-clog-ui-element="learn_more_plus" data-clog-ui-action="click" data-clog-ui-step="TEAM_NAV_PLANS_MENU"href="https://slack.com/pricing/plus?ui_element=54&ui_step=222">
												<span class="switcher_label">Plus</span>
					</a></li>
					<li class="plans_switcher_item "><a data-clog-event="UPGRDEXP_PLANS_IN_TEAM_NAV" data-clog-ui-element="learn_more_enterprise" data-clog-ui-action="click" data-clog-ui-step="TEAM_NAV_PLANS_MENU"href="https://slack.com/plans/enterprise-grid?ui_element=55&ui_step=222">
												<span class="switcher_label">Enterprise</span>
					</a></li>
					<li class="plans_switcher_item "><a data-clog-event="UPGRDEXP_PLANS_IN_TEAM_NAV" data-clog-ui-element="pricing_link" data-clog-ui-action="click" data-clog-ui-step="TEAM_NAV_PLANS_MENU"href="https://slack.com/plans/compare?ui_element=5&ui_step=222">
												<span class="switcher_label">Compare plans</span>
					</a></li>
				</ul>

				<a href="" onclick="return false;" id="team_switcher" data-qa="team_switcher">
					<i class="ts_icon ts_icon_th_large ts_icon_inherit"></i>
					<span class="block label">Workspaces</span>
				</a>
				<a href="/help" id="help_link" data-qa="help_link">
					<i class="ts_icon ts_icon_life_ring ts_icon_inherit"></i>
					<span class="block label">Help</span>
				</a>
															<a href="/messages" data-qa="launch">
							<img src="https://a.slack-edge.com/66f9/img/icons/ios-64.png" srcset="https://a.slack-edge.com/66f9/img/icons/ios-32.png 1x, https://a.slack-edge.com/66f9/img/icons/ios-64.png 2x" title="Slack" alt="Launch Slack"/>
							<span class="block label">Launch</span>
						</a>
												</div>
							<ul id="header_team_nav" data-qa="team_switcher_menu">
																		
<li class="active">
	<a href="https://playmakertalk.slack.com/home" target="https://playmakertalk.slack.com/">
					<i class="ts_icon small ts_icon_check_circle_o active_icon s"></i>
							<i class="team_icon small" style="background-image: url('https://slack-files2.s3-us-west-2.amazonaws.com/avatars/2017-03-17/156575961255_e5507712ca66930a469b_88.gif');"></i>
				<span class="switcher_label team_name">Playmaker</span>
	</a>
</li>																<li id="add_team_option"><a href="https://slack.com/signin" target="_blank"><i class="ts_icon ts_icon_plus team_icon small"></i> <span class="switcher_label">Sign in to another workspace &hellip;</span></a></li>
				</ul>
					</div>
	
	
	
</header>	
	<div id="page" >

		<div id="page_contents" data-qa="page_contents" class="">

<p class="print_only">
	<strong>
	
	Created by tcmeric on Wednesday, September 6, 2017 at 1:00 AM
	</strong><br />
	<span class="subtle_silver break_word">https://playmakertalk.slack.com/files/U4KRJPX98/F6YBQU7C3/generateseedint.cs</span>
</p>

<div class="file_header_container no_print"></div>

<div class="alert_container">
		

<div class="file_public_link_shared alert" style="display: none;">
			<a id="file_public_link_revoker" class="btn btn_small btn_outline float_right" data-toggle="tooltip" title="You can revoke the public link to this file. This will cause any previously shared links to stop working.">Revoke</a>
		
	<i class="ts_icon ts_icon_link"></i> Public Link: <a class="file_public_link" href="https://slack-files.com/T4K5M4D41-F6YBQU7C3-e6d850281a" target="new">https://slack-files.com/T4K5M4D41-F6YBQU7C3-e6d850281a</a>
</div></div>

<div id="file_page" class="card top_padding">

	<p class="small subtle_silver no_print meta">
		
		1KB C# snippet created on <span class="date">September 6, 2017</span>.
						<span class="file_share_list"></span>
	</p>

	<a id="file_action_cog" class="action_cog action_cog_snippet float_right no_print">
		<span>Actions </span><i class="ts_icon ts_icon_cog"></i>
	</a>
	<a id="snippet_expand_toggle" class="float_right no_print">
		<i class="ts_icon ts_icon_expand "></i>
		<i class="ts_icon ts_icon_compress hidden"></i>
	</a>

	<div class="large_bottom_margin clearfix">
		<pre id="file_contents">using UnityEngine;
using System.Collections;
using Experilous.MakeItRandom;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(&quot;Random Values&quot;)]
	[Tooltip(&quot;Create a random seed value using an INT as the seed.&quot;)]
	public class GenerateSeedInt : FsmStateAction
	{
		
		[CheckForComponent(typeof(storeRandom))]
		[Title(&quot;Random Holder&quot;)]  
		public FsmOwnerDefault gameObject;
		
		[RequiredField]
		[Tooltip(&quot;Set random seed value using an int.&quot;)]
		public FsmInt Seed;
		
		// private variables
		
		private XorShift128Plus _randomGen;
		private storeRandom store;
		
		public override void Reset()
		{
			Seed = null;
			gameObject = null;
		}
		
		public override void OnEnter()
		{

			doValue();
			Finish();
		}
		
		void doValue()
		{
			
			if(Seed.Value == null)
			{
				return;
			}
			
			var go = Fsm.GetOwnerDefaultTarget(gameObject);
			var store = go.GetComponent&lt;storeRandom&gt;();
			
			_randomGen = XorShift128Plus.Create(Seed.Value);
			Debug.Log(_randomGen);
			store.randomGen = _randomGen;

		}
		
	}
}
</pre>

		<p class="file_page_meta no_print" style="line-height: 1.5rem;">
			<label class="checkbox normal mini float_right no_top_padding no_min_width">
				<input type="checkbox" id="file_preview_wrap_cb"> wrap long lines			</label>
		</p>

	</div>

			<div id="comments_holder" class="clearfix clear_both">
	<div class="col span_1_of_6"></div>
	<div class="col span_4_of_6 no_right_padding">
		<div id="file_page_comments">
			

<div class="loading_hash_animation">
	<span class=loading_hash_container><img src="https://a.slack-edge.com/9c217/img/loading_hash_animation_@2x.gif" srcset="https://a.slack-edge.com/9c217/img/loading_hash_animation.gif 1x, https://a.slack-edge.com/9c217/img/loading_hash_animation_@2x.gif 2x" alt="Loading" class="loading_hash" /><br />loading...</span>
	<noscript>
		
			You must enable javascript in order to use Slack :(
						<style type="text/css">span.loading_hash_container { display: none; }</style>
	</noscript>
</div>		</div>	
		

	<p class="p-external_file_author_notice hidden">
		
			<strong class="dull_grey">Can’t view comments</strong><br />
			This file is from another workspace.
			</p>

	<form action="https://playmakertalk.slack.com/files/U4KRJPX98/F6YBQU7C3/generateseedint.cs"
			id="file_comment_form"
							class="comment_form clearfix"
						method="post">
					<a href="/team/U4KRJPX98" class="member_preview_link" data-member-id="U4KRJPX98" >
				<span class="member_image thumb_36" style="background-image: url('https://avatars.slack-edge.com/2017-03-17/156576633431_72257b76199013178457_72.png')" data-thumb-size="36" data-member-id="U4KRJPX98"></span>
			</a>
				<input type="hidden" name="addcomment" value="1" />
		<input type="hidden" name="crumb" value="s-1523196698-e7453400f582f4bf96006cba5d9d31e758438ad36ea22458e20eb96ead6b6577-☃" />

		<div id="file_comment" class="small texty_comment_input comment_input small_bottom_margin" name="comment" wrap="virtual" ></div>
		<div class="file_comment_submit_container display_flex justify_content_between">
			<button type="submit" class="file_comment_submit_btn btn align_self_start   ladda-button" data-style="expand-right"><span class="ladda-label">Add Comment</span></button>
			<span class="input_note indifferent_grey file_comment_tip">shift+enter to add a new line</span>		</div>
	</form>

<form
		id="file_edit_comment_form"
					class="edit_comment_form clearfix hidden"
				method="post">
		<div id="file_edit_comment" class="small texty_comment_input comment_input small_bottom_margin" name="comment" wrap="virtual"></div>
	<input type="submit" class="save btn float_right " value="Save" />
	<button class="cancel btn btn_outline float_right small_right_margin ">Cancel</button>
</form>	
	</div>
	<div class="col span_1_of_6"></div>
</div>	
</div>


	
		
	</div>
	<div id="overlay"></div>
</div>







<script type="text/javascript">

	/**
	 * A placeholder function that the build script uses to
	 * replace file paths with their CDN versions.
	 *
	 * @param {String} file_path - File path
	 * @returns {String}
	 */
	function vvv(file_path) {

		var vvv_warning = 'You cannot use vvv on dynamic values. Please make sure you only pass in static file paths.';
		if (TS && TS.warn) {
			TS.warn(vvv_warning);
		} else {
			console.warn(vvv_warning);
		}

		return file_path;
	}

	var cdn_url = "https:\/\/a.slack-edge.com";
	var vvv_abs_url = "https:\/\/slack.com\/";
	var inc_js_setup_data = {
			emoji_sheets: {
			apple: 'https://a.slack-edge.com/c00d19/img/emoji_2017_12_06/sheet_apple_64_indexed_256.png',
			google: 'https://a.slack-edge.com/c00d19/img/emoji_2017_12_06/sheet_google_64_indexed_256.png',
		},
		emoji5: true,
		};
</script>
	<script type="text/javascript">
<!--
	// common boot_data
	var boot_data = {
		start_ms: Date.now(),
		app: "web",
		user_id: 'U4KRJPX98',
		team_id: 'T4K5M4D41',
		visitor_uid: ".eif1dchrro8c44kog040ss8ws",
		no_login: false,
		version_ts: "1523195532",
		version_uid: "1080460bbd9e2157c4f3eac8edfc2e3e336cc20b",
		cache_version: "v16-giraffe",
		cache_ts_version: "v2-bunny",
		redir_domain: "slack-redir.net",
		signin_url: 'https://slack.com/signin',
		abs_root_url: "https:\/\/slack.com\/",
		api_url: '/api/',
		team_url: "https:\/\/playmakertalk.slack.com\/",
		image_proxy_url: "https:\/\/slack-imgs.com\/",
		beacon_timing_url: "https:\/\/slack.com\/beacon\/timing",
		beacon_error_url: "https:\/\/slack.com\/beacon\/error",
		clog_url: "clog\/track\/",
		api_token: "xoxs-155191149137-155868813314-338998331396-9f6d235915",
		ls_disabled: false,
		hc_tracking_qs: "sid=zd-of-t4k5m4d41-u4krjpx98",

		vvv_paths: {
			
		lz_string: "https:\/\/a.slack-edge.com\/bv1-1\/lz-string-1.4.4.worker.8de1b00d670ff3dc706a0.js",
		codemirror: "https:\/\/a.slack-edge.com\/bv1-1\/codemirror.min.44a2b0ae2d7a5cac8a95.min.js",
	codemirror_addon_simple: "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_simple.9c76f7896754967b9eda.min.js",
	codemirror_load: "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_load.5afece10ceabb3d91968.min.js",

	// Silly long list of every possible file that Codemirror might load
	codemirror_files: {
		'apl': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_apl.28ce658730a18a115532.min.js",
		'asciiarmor': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_asciiarmor.b6cae5185b1e92ac1917.min.js",
		'asn.1': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_asn.1.1992736a46ff4b01f93f.min.js",
		'asterisk': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_asterisk.8dc14a25826407ab1fa3.min.js",
		'brainfuck': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_brainfuck.d29773c7ac178228d4c1.min.js",
		'clike': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_clike.cccd21c94a2b7ab7ce3d.min.js",
		'clojure': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_clojure.4a91a0c50a64467f2ff5.min.js",
		'cmake': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_cmake.a873ff1604fb8e89955f.min.js",
		'cobol': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_cobol.2b7098fad4936f18f361.min.js",
		'coffeescript': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_coffeescript.68a8fdd315d0dcf8c27a.min.js",
		'commonlisp': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_commonlisp.879f5b578b25a058fc4d.min.js",
		'css': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_css.035ca224464953138c30.min.js",
		'crystal': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_crystal.79beb330be1a294e43c4.min.js",
		'cypher': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_cypher.525ea24cf7710ac2825a.min.js",
		'd': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_d.7328ff9ab8c98103deb7.min.js",
		'dart': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_dart.f7e22fcf397d31e7af93.min.js",
		'diff': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_diff.c3b6cf00600144071d6d.min.js",
		'django': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_django.cde302c62fe6365529f2.min.js",
		'dockerfile': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_dockerfile.ed0e37e03b2023e1b69b.min.js",
		'dtd': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_dtd.df3795754645134d5f80.min.js",
		'dylan': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_dylan.fed72f1d0e846fd6d213.min.js",
		'ebnf': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_ebnf.6af113fdedf587f96c64.min.js",
		'ecl': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_ecl.12b9206b24a5433649ab.min.js",
		'eiffel': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_eiffel.896ceb473406cc01ee59.min.js",
		'elm': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_elm.637ce7bda68e33c4b55a.min.js",
		'erlang': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_erlang.ea42edc0caacbb7b9429.min.js",
		'factor': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_factor.937f3b4ba675a2abe9c7.min.js",
		'forth': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_forth.89f6ec54d5548d4cf25b.min.js",
		'fortran': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_fortran.e312d7972b690a22beab.min.js",
		'gas': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_gas.abc6e9d7c3a0b887ff69.min.js",
		'gfm': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_gfm.8fc0c8e3735d10a858c6.min.js",
		'gherkin': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_gherkin.9e0cfa25c1965e495419.min.js",
		'go': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_go.5ed96d85ab19d7795ba7.min.js",
		'groovy': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_groovy.c496c31bd5cca0986ead.min.js",
		'haml': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_haml.f25c65cf09f1ec3a29c7.min.js",
		'handlebars': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_handlebars.80eb7b9e2e0fb6dee382.min.js",
		'haskell': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_haskell.e7b2cc288c6bd281ff32.min.js",
		'haxe': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_haxe.3efebdfa3dc7fb7cc4db.min.js",
		'htmlembedded': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_htmlembedded.1a2496c621f9a470c340.min.js",
		'htmlmixed': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_htmlmixed.caa675603dc4fdb90c31.min.js",
		'http': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_http.c1c249d14bf18521fee1.min.js",
		'idl': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_idl.715601d44fbe133c065b.min.js",
		'jade': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_jade.0eff9474d977d43feced.min.js",
		'javascript': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_javascript.bc1b5c6a6515b3064108.min.js",
		'jinja2': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_jinja2.5de8bc52face9b2769f2.min.js",
		'julia': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_julia.32d8748fecc17e6305bf.min.js",
		'livescript': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_livescript.f6dbad1e8d8168b319f4.min.js",
		'lua': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_lua.32780d85e5cbbb59b8eb.min.js",
		'markdown': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_markdown.a7f65f93ece1f31b9e60.min.js",
		'mathematica': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_mathematica.48dd3694f2f71a75544c.min.js",
		'mirc': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_mirc.0f3984162d72c3a0a5ca.min.js",
		'mllike': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_mllike.e4e86126535bd4f7a575.min.js",
		'modelica': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_modelica.d4fd8938619f5c8dc361.min.js",
		'mscgen': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_mscgen.f9d5ab8e95b697c39880.min.js",
		'mumps': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_mumps.b361377133b59678d3d5.min.js",
		'nginx': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_nginx.524bfc39589c37f74bfd.min.js",
		'nsis': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_nsis.b25852c3418f984ae03d.min.js",
		'ntriples': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_ntriples.4e0443a64025c35438a6.min.js",
		'octave': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_octave.3a0c99a5e07bbd9a6d67.min.js",
		'oz': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_oz.e9939d375a47087f59aa.min.js",
		'pascal': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_pascal.f1162aeab4a781363ccd.min.js",
		'pegjs': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_pegjs.7af50308b76ba3251b02.min.js",
		'perl': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_perl.5a7940afe30ba510820a.min.js",
		'php': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_php.64b619fb529d1cd9b781.min.js",
		'pig': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_pig.a30ec6f3ffff33476ac4.min.js",
		'powershell': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_powershell.0ccd1b6a33eb2209c15b.min.js",
		'properties': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_properties.5c0c1436978bf2a7af00.min.js",
		'puppet': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_puppet.53ac0d4fadd68369610e.min.js",
		'python': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_python.dd3e2e25db7e7fb868d6.min.js",
		'q': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_q.4af8c1d9b07ea218977f.min.js",
		'r': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_r.783001720b360a8177a8.min.js",
		'rpm': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_rpm.79678546fb25c75e3208.min.js",
		'rst': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_rst.0fa19c56ae79c0b70c27.min.js",
		'ruby': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_ruby.efce7fd348530776314b.min.js",
		'rust': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_rust.b148ea62a65dfe9f36c0.min.js",
		'sass': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_sass.4e58ddf440975d3864f6.min.js",
		'scheme': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_scheme.52a48304089db7f7708e.min.js",
		'shell': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_shell.8dd47832ce011f080fb8.min.js",
		'sieve': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_sieve.dc92cd9b919e5efb3c05.min.js",
		'slim': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_slim.ba0d300bced932d16420.min.js",
		'smalltalk': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_smalltalk.6dd6e1d419b04500b385.min.js",
		'smarty': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_smarty.428329a9fdb0d8be2a5f.min.js",
		'solr': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_solr.02f1fe78feb4a670b6cc.min.js",
		'soy': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_soy.8145a09e761fee4b0667.min.js",
		'sparql': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_sparql.cf7a2190284c6ca0c11d.min.js",
		'spreadsheet': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_spreadsheet.eeeb35132617f7fa05e6.min.js",
		'sql': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_sql.78a665f0a117e62e46f2.min.js",
		'stex': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_stex.777bff71a93e84be5096.min.js",
		'stylus': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_stylus.6ae0e46fb8c0750c644c.min.js",
		'swift': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_swift.2254c736e8a7f4f51e92.min.js",
		'tcl': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_tcl.13833d90818d7aa20cc6.min.js",
		'textile': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_textile.aa7de5d427d0474f6e14.min.js",
		'tiddlywiki': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_tiddlywiki.efa88c874dc2653bb47e.min.js",
		'tiki': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_tiki.6a8e59872a533ec09dae.min.js",
		'toml': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_toml.4e099e2ec0d834eb7c04.min.js",
		'tornado': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_tornado.feede7e509e683f0998f.min.js",
		'troff': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_troff.d31a17f22f8c679cf3e5.min.js",
		'ttcn': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_ttcn.1bf6637cf05b45897ccd.min.js",
		'ttcn:cfg': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_ttcn-cfg.273e541df1ddc66215ca.min.js",
		'turtle': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_turtle.4cf803c3d74096bfb82a.min.js",
		'twig': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_twig.628d79da0aea153a66fe.min.js",
		'vb': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_vb.828b80361395c4e24aaf.min.js",
		'vbscript': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_vbscript.e19473b2883a8f5e9270.min.js",
		'velocity': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_velocity.09039c2d8f038c5046b2.min.js",
		'verilog': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_verilog.f12abef9991c95696bf5.min.js",
		'vhdl': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_vhdl.6438b130790bb71537f5.min.js",
		'vue': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_vue.b7dca682b49e1cb360cf.min.js",
		'xml': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_xml.c067158d12d43b9b96f7.min.js",
		'xquery': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_xquery.340466967c2bdf65fa66.min.js",
		'yaml': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_yaml.7f71c0f462159ba81033.min.js",
		'z80': "https:\/\/a.slack-edge.com\/bv1-1\/codemirror_lang_z80.73d5eb24ebcdece24ced.min.js"
	}		},

		notification_sounds: [{"value":"b2.mp3","label":"Ding","url":"https:\/\/slack.global.ssl.fastly.net\/7e91\/sounds\/push\/b2.mp3","url_ogg":"https:\/\/slack.global.ssl.fastly.net\/46ebb\/sounds\/push\/b2.ogg"},{"value":"animal_stick.mp3","label":"Boing","url":"https:\/\/slack.global.ssl.fastly.net\/7e91\/sounds\/push\/animal_stick.mp3","url_ogg":"https:\/\/slack.global.ssl.fastly.net\/46ebb\/sounds\/push\/animal_stick.ogg"},{"value":"been_tree.mp3","label":"Drop","url":"https:\/\/slack.global.ssl.fastly.net\/7e91\/sounds\/push\/been_tree.mp3","url_ogg":"https:\/\/slack.global.ssl.fastly.net\/46ebb\/sounds\/push\/been_tree.ogg"},{"value":"complete_quest_requirement.mp3","label":"Ta-da","url":"https:\/\/slack.global.ssl.fastly.net\/7e91\/sounds\/push\/complete_quest_requirement.mp3","url_ogg":"https:\/\/slack.global.ssl.fastly.net\/46ebb\/sounds\/push\/complete_quest_requirement.ogg"},{"value":"confirm_delivery.mp3","label":"Plink","url":"https:\/\/slack.global.ssl.fastly.net\/7e91\/sounds\/push\/confirm_delivery.mp3","url_ogg":"https:\/\/slack.global.ssl.fastly.net\/46ebb\/sounds\/push\/confirm_delivery.ogg"},{"value":"flitterbug.mp3","label":"Wow","url":"https:\/\/slack.global.ssl.fastly.net\/7e91\/sounds\/push\/flitterbug.mp3","url_ogg":"https:\/\/slack.global.ssl.fastly.net\/46ebb\/sounds\/push\/flitterbug.ogg"},{"value":"here_you_go_lighter.mp3","label":"Here you go","url":"https:\/\/slack.global.ssl.fastly.net\/7e91\/sounds\/push\/here_you_go_lighter.mp3","url_ogg":"https:\/\/slack.global.ssl.fastly.net\/46ebb\/sounds\/push\/here_you_go_lighter.ogg"},{"value":"hi_flowers_hit.mp3","label":"Hi","url":"https:\/\/slack.global.ssl.fastly.net\/7e91\/sounds\/push\/hi_flowers_hit.mp3","url_ogg":"https:\/\/slack.global.ssl.fastly.net\/46ebb\/sounds\/push\/hi_flowers_hit.ogg"},{"value":"knock_brush.mp3","label":"Knock Brush","url":"https:\/\/slack.global.ssl.fastly.net\/7e91\/sounds\/push\/knock_brush.mp3","url_ogg":"https:\/\/slack.global.ssl.fastly.net\/46ebb\/sounds\/push\/knock_brush.ogg"},{"value":"save_and_checkout.mp3","label":"Whoa!","url":"https:\/\/slack.global.ssl.fastly.net\/7e91\/sounds\/push\/save_and_checkout.mp3","url_ogg":"https:\/\/slack.global.ssl.fastly.net\/46ebb\/sounds\/push\/save_and_checkout.ogg"},{"value":"item_pickup.mp3","label":"Yoink","url":"https:\/\/slack.global.ssl.fastly.net\/7e91\/sounds\/push\/item_pickup.mp3","url_ogg":"https:\/\/slack.global.ssl.fastly.net\/46ebb\/sounds\/push\/item_pickup.ogg"},{"value":"hummus.mp3","label":"Hummus","url":"https:\/\/slack.global.ssl.fastly.net\/7fa9\/sounds\/push\/hummus.mp3","url_ogg":"https:\/\/slack.global.ssl.fastly.net\/46ebb\/sounds\/push\/hummus.ogg"},{"value":"none","label":"None"}],
		alert_sounds: [{"value":"frog.mp3","label":"Frog","url":"https:\/\/slack.global.ssl.fastly.net\/a34a\/sounds\/frog.mp3"}],
		call_sounds: [{"value":"call\/alert_v2.mp3","label":"Alert","url":"https:\/\/slack.global.ssl.fastly.net\/08f7\/sounds\/call\/alert_v2.mp3"},{"value":"call\/incoming_ring_v2.mp3","label":"Incoming ring","url":"https:\/\/slack.global.ssl.fastly.net\/08f7\/sounds\/call\/incoming_ring_v2.mp3"},{"value":"call\/outgoing_ring_v2.mp3","label":"Outgoing ring","url":"https:\/\/slack.global.ssl.fastly.net\/08f7\/sounds\/call\/outgoing_ring_v2.mp3"},{"value":"call\/pop_v2.mp3","label":"Incoming reaction","url":"https:\/\/slack.global.ssl.fastly.net\/08f7\/sounds\/call\/pop_v2.mp3"},{"value":"call\/they_left_call_v2.mp3","label":"They left call","url":"https:\/\/slack.global.ssl.fastly.net\/08f7\/sounds\/call\/they_left_call_v2.mp3"},{"value":"call\/you_left_call_v2.mp3","label":"You left call","url":"https:\/\/slack.global.ssl.fastly.net\/08f7\/sounds\/call\/you_left_call_v2.mp3"},{"value":"call\/they_joined_call_v2.mp3","label":"They joined call","url":"https:\/\/slack.global.ssl.fastly.net\/08f7\/sounds\/call\/they_joined_call_v2.mp3"},{"value":"call\/you_joined_call_v2.mp3","label":"You joined call","url":"https:\/\/slack.global.ssl.fastly.net\/08f7\/sounds\/call\/you_joined_call_v2.mp3"},{"value":"call\/confirmation_v2.mp3","label":"Confirmation","url":"https:\/\/slack.global.ssl.fastly.net\/08f7\/sounds\/call\/confirmation_v2.mp3"}],
		call_sounds_version: "v2",
				default_tz: "America\/Los_Angeles",
		
		feature_tinyspeck: false,
		feature_create_team_google_auth: false,
		feature_enterprise_custom_tos: true,
		feature_webapp_always_collect_initial_time_period_stats: false,
		feature_search_skip_context: false,
		feature_buildy_css: false,
		feature_flannel_use_canary_sometimes: false,
		feature_deprecate_window_cert: true,
		feature_deprecate_window_cert_block: true,
		feature_deprecate_files: false,
		feature_deprecate_get_member_by_name: false,
		feature_modern_set_last_read: false,
		feature_modern_process_imsg: false,
		feature_modern_message_changed: false,
		feature_file_threads: false,
		feature_file_threads_dark_launch: false,
		feature_file_threads_cache_update: false,
		feature_more_pins_info: false,
		feature_threads_perf: false,
		feature_message_replies_inline: false,
		feature_subteam_members_diff: true,
		feature_a11y_keyboard_shortcuts: false,
		feature_email_ingestion: false,
		feature_api_site_tools: false,
		feature_msg_consistency: false,
		feature_sidebar_context_menu: false,
		feature_attachments_inline: false,
		feature_fix_files: true,
		feature_channel_eventlog_client: true,
		feature_paging_api: false,
		feature_custom_status_expiry: false,
		feature_m11n_custom_status_input: false,
		feature_m11n_channel_rtm_handlers: false,
		feature_sonic_dnd: false,
		feature_enterprise_app_teams: true,
		feature_enterprise_frecency: true,
		feature_ent_app_management_dashboard: true,
		feature_set_away_dialog_behavior: true,
		feature_ent_app_management_restriction: false,
		feature_entitlements: true,
		feature_grid_archive_link_fixes: true,
		feature_dunning: true,
		feature_invoice_dunning: true,
		feature_safeguard_org_retention: true,
		feature_dashboard_sortable_lists: false,
		feature_refactor_admin_stats: false,
		feature_invite_only_workspaces: true,
		feature_leave_workspace_improvements: true,
		feature_enteprise_user_teams_update: false,
		feature_enterprise_org_wide_channels_section: true,
		feature_show_billing_active_for_grid: true,
		feature_find_your_workspace: true,
		feature_compliance_export_helper_copy: false,
		feature_form_text_character_count_copy: false,
		feature_sk_lato_cleanup: false,
		feature_saml_authn_key_expiry_date: true,
		feature_wta_client_support: true,
		feature_xoxa_channel_authorization: true,
		feature_wta_optional_ephemeral_message: false,
		feature_file_links_betterer: false,
		feature_enterprise_dm_deeplink: false,
		feature_session_duration_saved_message: false,
		feature_guest_api_changes: false,
		feature_sso_jit_disabling: true,
		feature_connecting_shared_channels_enterprise: false,
		feature_shared_channels_enterprise: false,
		feature_snapshots_the_revenge: false,
		feature_mpim_channels: false,
		feature_esc_connected_workspaces_search: false,
		feature_deprecate_gateways: true,
		feature_conversations_list: true,
		feature_gdpr_user_join_tos: false,
		feature_modernize_admin: false,
		feature_winssb_beta_channel: false,
		feature_slack_astronaut_i18n_jpn: true,
		feature_i18n_customer_stories: false,
		feature_cust_acq_i18n_tweaks: false,
		feature_gdpr_website_update: true,
		feature_gdpr_website_fixes: false,
		feature_gdpr_forget_user: false,
		feature_sales_lp: true,
		feature_presence_sub: true,
		feature_whitelist_zendesk_chat_widget: false,
		feature_live_support_free_plan: false,
		feature_slackbot_goes_to_college: false,
		feature_newxp_enqueue_message: true,
		feature_teambot: false,
		feature_star_shortcut: false,
		feature_show_jumper_scores: true,
		feature_force_ls_compression: false,
		feature_name_tagging_client: true,
		feature_name_tagging_client_autocomplete: false,
		feature_name_tagging_client_topic_purpose: false,
		feature_use_imgproxy_resizing: true,
		feature_share_mention_comment_cleanup: false,
		feature_external_files: false,
		feature_electron_memory_logging: false,
		feature_decomp_misc_reads: false,
		feature_modernize_slash_cmds: false,
		feature_i18n_escape: false,
		feature_i18n_runtime_translations: false,
		feature_channel_exports: false,
		feature_corp_eng_news: false,
		feature_take_profile_photo: false,
		feature_arugula: false,
		feature_texty_rewrite_on_paste: false,
		feature_deprecate_screenhero: true,
		feature_calls_esc_ui: true,
		feature_toggle_id_translation: true,
		feature_modern_api_q: false,
		feature_default_shared_channels: true,
		feature_default_shared_channels_whats_new: true,
		feature_email_notifications_improvements: true,
		feature_react_lfs: false,
		feature_log_quickswitcher_queries: true,
		feature_enable_mdm: true,
		feature_message_menus: true,
		feature_new_message_click_logging: true,
		feature_announce_only_channels: false,
		feature_app_permissions_backend_enterprise: true,
		feature_token_ip_whitelist: true,
		feature_hide_join_leave: false,
		feature_rollback_to_mapping: false,
		feature_emoji5: true,
		feature_sidebar_theme_undo: false,
		feature_emoji5_dark_launch: true,
		feature_feature_emoji5: false,
		feature_allow_intra_word_formatting: true,
		feature_allow_cjk_autocomplete: true,
		feature_allow_split_word: false,
		feature_i18n_channels_validate_emoji: true,
		feature_fw_eng_normalization: false,
		feature_slim_scrollbar: false,
		feature_search_query_refinements: true,
		feature_search_spell_corrections: false,
		feature_react_search: false,
		feature_prefs_modernization: false,
		feature_sidebar_filters: false,
		feature_sli_channel_archive_suggestions: true,
		feature_unread_counts_without_history: true,
		feature_react_messages: true,
		feature_clipboard_contents: true,
		feature_redux_modals: false,
		feature_react_pin_author: true,
		feature_mrkdwn_truncation: true,
		feature_m11n_channels_join: true,
		feature_growls_m11n: false,
		feature_growls_m11n_prod: false,
		feature_m11n_metrics_responsiveness: false,
		feature_react_member_profile_card: false,
		feature_service_import_lfs: false,
		feature_mpdm_default_fe: false,
		feature_channel_notif_dialog_update: false,
		feature_oauth_react_wta: false,
		feature_react_team_picker: false,
		feature_app_index: false,
		feature_app_profile_app_site_link: false,
		feature_custom_app_installs: false,
		feature_gdrive_do_not_install_by_default: true,
		feature_delete_moved_channels: true,
		feature_single_workspace_redirect: true,
		feature_zero_workspace_onboarding: true,
		feature_user_tos: false,
		feature_oom_mv_channels_list: false,
		feature_solr_discoverability: true,
		feature_sso_formatting_error: true,
		feature_single_user_workspace_pagination: true,
		feature_default_workspaces_to_closed: true,
		feature_ms_msg_handlers_profiling: true,
		feature_cross_workspace_quick_switcher_prototype: true,
		feature_org_quick_switcher: false,
		feature_user_prefs_merge_using_custom_callbacks: true,
		feature_ms_latest: true,
		feature_no_preload_video: true,
		feature_guests_use_entitlements: true,
		feature_emoji_picker_frecently_used: false,
		feature_app_space: true,
		feature_app_canvases: false,
		feature_canvases: false,
		feature_stop_loud_channel_mentions: false,
		feature_message_input_byte_limit: false,
		feature_beacon_js_errors: false,
		feature_http_sendmsg: false,
		feature_app_dialogs_textarea_count: true,
		feature_dialogs_v2_mobile: false,
		feature_user_app_disable_speed_bump: false,
		feature_nudge_team_creators: false,
		feature_onedrive_picker: false,
		feature_lesson_onboarding: true,
		feature_disable_join_notifications: false,
		feature_api_admin_page_not_ent: true,
		feature_faster_channels_browser_render: true,
		feature_non_blocking_user_boot: true,
		feature_non_wasted_flannel_connection: true,
		feature_no_files_info: true,
		feature_less_pins: true,
		feature_runaway_qs: true,
		feature_dark_qs: false,
		feature_no_frecency_storage: true,
		feature_typeless_upsert_channel: false,
		feature_delete_team_and_apps: true,
		feature_email_forwarding: true,
		feature_pjpeg: false,
		feature_pdf_thumb: true,
		feature_apps_manage_permissions_scope_changes: true,
		feature_app_dir_only_default_true: false,
		feature_reminder_cross_workspace: false,
		feature_speedy_boot_handlebars: false,
		feature_better_web_app_model: false,
		feature_channel_invite_modal_cannot_join: false,
		feature_expiring_credits: true,
		feature_email_prefs: true,
		feature_pricing_calculator: false,
		feature_sonic: false,
		feature_flannel_channels_v0: false,
		feature_flannel_always_use_canary: false,
		feature_lazy_channels: false,
		feature_global_nav: false,
		feature_message_spacing: false,
		feature_shortcuts_flexpane: true,
		feature_app_directory_home_page_redesign: true,
		feature_hidden_wksp_unfurls: true,
		feature_guest_wksp_unfurls: false,
		feature_workspace_scim_management: false,
		feature_email_previewer: false,
		feature_redux_dev_tools: false,
		feature_unified_member: false,
		feature_angie_translations: false,
		feature_turn_mpdm_notifs_on: true,
		feature_browser_dragndrop: false,
		feature_granular_shared_channel_perms: false,
		feature_org_detailed_thread_mentions: true,
		feature_force_production_channel: false,
		feature_quill_upgrade: true,
		feature_offline_hint: false,
		feature_aria_msg_summary: false,
		feature_emoji_substr_search_tweaks: false,
		feature_texty_formatting_commands: false,
		feature_texty_change_queue: false,
		feature_send_button_for_everyone: false,
		feature_bots_not_members: false,
		feature_wta_user_data_fe: false,
		feature_shortcuts_prompt: true,
		feature_accessible_dialogs: true,
		feature_app_actions: false,
		feature_app_actions_fe: false,
		feature_app_actions_fe_frecency: false,
		feature_app_actions_global: false,
		feature_app_actions_response_url: true,
		feature_shared_channel_free_trial_flow: true,
		feature_i18n_compliance_links: false,
		feature_calls_clipboard_broadcasting_optin: true,
		feature_autocomplete_files: true,
		feature_screen_share_needs_aero: false,
		feature_calls_disable_iss_admin: true,
		feature_sidebar_realtime_priority: false,
		feature_in_prod_trials: true,
		feature_billing_ce_request_last4: true,
		feature_sli_explore: false,
		feature_sli_trending_dashboard: false,
		feature_i18n_custom_status: false,
		feature_i18n_select_empty_state_string: false,
		feature_drift_on_plans_page: true,
		feature_cjk_highlight_words: true,
		feature_accessible_fs_dialogs: true,
		feature_channel_browser_dropdown: true,
		feature_slackday_unsent_msg_sync: false,
		feature_trap_kb_within_fs_modals: true,
		feature_date_picker: false,
		feature_dialog_speedbump: true,
		feature_react_customize_emoji: false,

	client_logs: {"0":{"numbers":[0],"user_facing":false},"2":{"numbers":[2],"user_facing":false},"4":{"numbers":[4],"user_facing":false},"5":{"numbers":[5],"user_facing":false},"23":{"numbers":[23],"user_facing":false},"sounds":{"name":"sounds","numbers":[37]},"37":{"name":"sounds","numbers":[37],"user_facing":true},"47":{"numbers":[47],"user_facing":false},"48":{"numbers":[48],"user_facing":false},"Message History":{"name":"Message History","numbers":[58]},"58":{"name":"Message History","numbers":[58],"user_facing":true},"67":{"numbers":[67],"user_facing":false},"72":{"numbers":[72],"user_facing":false},"73":{"numbers":[73],"user_facing":false},"82":{"numbers":[82],"user_facing":false},"88":{"numbers":[88],"user_facing":false},"91":{"numbers":[91],"user_facing":false},"93":{"numbers":[93],"user_facing":false},"96":{"numbers":[96],"user_facing":false},"99":{"numbers":[99],"user_facing":false},"Channel Marking (MS)":{"name":"Channel Marking (MS)","numbers":[141]},"141":{"name":"Channel Marking (MS)","numbers":[141],"user_facing":true},"Channel Marking (Client)":{"name":"Channel Marking (Client)","numbers":[142]},"142":{"name":"Channel Marking (Client)","numbers":[142],"user_facing":true},"Close Old IMs (Client)":{"name":"Close Old IMs (Client)","numbers":[221]},"221":{"name":"Close Old IMs (Client)","numbers":[221],"user_facing":true},"365":{"numbers":[365],"user_facing":false},"389":{"numbers":[389],"user_facing":false},"438":{"numbers":[438],"user_facing":false},"444":{"numbers":[444],"user_facing":false},"481":{"numbers":[481],"user_facing":false},"488":{"numbers":[488],"user_facing":false},"529":{"numbers":[529],"user_facing":false},"552":{"numbers":[552],"user_facing":false},"dashboard":{"name":"dashboard","numbers":[666]},"666":{"name":"dashboard","numbers":[666],"user_facing":false},"667":{"numbers":[667],"user_facing":false},"773":{"numbers":[773],"user_facing":false},"777":{"numbers":[777],"user_facing":false},"794":{"numbers":[794],"user_facing":false},"Client Responsiveness":{"name":"Client Responsiveness","user_facing":false,"numbers":[808]},"808":{"name":"Client Responsiveness","user_facing":false,"numbers":[808]},"Message Pane Scrolling":{"name":"Message Pane Scrolling","numbers":[888]},"888":{"name":"Message Pane Scrolling","numbers":[888],"user_facing":true},"Unread banner and divider":{"name":"Unread banner and divider","numbers":[999]},"999":{"name":"Unread banner and divider","numbers":[999],"user_facing":true},"1000":{"numbers":[1000],"user_facing":false},"Duplicate badges (desktop app icons)":{"name":"Duplicate badges (desktop app icons)","numbers":[1701]},"1701":{"name":"Duplicate badges (desktop app icons)","numbers":[1701],"user_facing":true},"Members":{"name":"Members","numbers":[1975]},"1975":{"name":"Members","numbers":[1975],"user_facing":true},"lazy loading":{"name":"lazy loading","numbers":[1989]},"1989":{"name":"lazy loading","numbers":[1989],"user_facing":true},"thin_channel_membership":{"name":"thin_channel_membership","numbers":[1990]},"1990":{"name":"thin_channel_membership","numbers":[1990],"user_facing":true},"stats":{"name":"stats","numbers":[1991]},"1991":{"name":"stats","numbers":[1991],"user_facing":true},"ms":{"name":"ms","numbers":[1996]},"1996":{"name":"ms","numbers":[1996],"user_facing":true},"shared_channels_connection":{"name":"shared_channels_connection","numbers":[1999]},"1999":{"name":"shared_channels_connection","numbers":[1999],"user_facing":false},"dnd":{"name":"dnd","numbers":[2002]},"2002":{"name":"dnd","numbers":[2002],"user_facing":true},"2003":{"numbers":[2003],"user_facing":false},"Threads":{"name":"Threads","numbers":[2004]},"2004":{"name":"Threads","numbers":[2004],"user_facing":true},"2005":{"numbers":[2005],"user_facing":false},"Reactions":{"name":"Reactions","numbers":[2006]},"2006":{"name":"Reactions","numbers":[2006],"user_facing":true},"TSSSB.focusTabAndSwitchToChannel":{"name":"TSSSB.focusTabAndSwitchToChannel","numbers":[2007]},"2007":{"name":"TSSSB.focusTabAndSwitchToChannel","numbers":[2007],"user_facing":false},"Presence Detection":{"name":"Presence Detection","numbers":[2017]},"2017":{"name":"Presence Detection","numbers":[2017],"user_facing":true},"mc_sibs":{"name":"mc_sibs","numbers":[9999]},"9999":{"name":"mc_sibs","numbers":[9999],"user_facing":false},"Member searching":{"name":"Member searching","numbers":[90211]},"90211":{"name":"Member searching","numbers":[90211],"user_facing":true},"98765":{"numbers":[98765],"user_facing":false},"8675309":{"numbers":[8675309],"user_facing":false}},


		img: {
			app_icon: 'https://a.slack-edge.com/272a/img/slack_growl_icon.png'
		},
		page_needs_custom_emoji: false,
		page_needs_enterprise: false	};

	
	
	
	
	// i18n locale map (eg: maps Slack `ja-jp` to ZD `ja`)
			boot_data.slack_to_zd_locale = {"en-us":"en-us","fr-fr":"fr-fr","de-de":"de","es-es":"es","ja-jp":"ja"};
	
	// client boot data
		
			boot_data.should_use_flannel = true;
				boot_data.page_has_incomplete_user_model = true;
		boot_data.flannel_server_pool = "random";
		
	
	
	
	
								boot_data.experiment_assignments = {"handlebars_from_smarty_perf":{"experiment_id":"46172931351","type":"user","group":"","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"smartybars_perf":{"experiment_id":"77818061717","type":"user","group":"","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"logstash_calls_client_logs":{"experiment_id":"79365041859","type":"user","group":"logstash_enabled","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"gdrive_1_5_coachmark_experiment":{"experiment_id":"94271365346","type":"user","group":"yes_coach_mark","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"calls_janus_beta":{"experiment_id":"111633435522","type":"user","group":"calls_janus_beta","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"channel_highlights_dark":{"experiment_id":"134435672660","type":"user","group":"channel_highlights_dark","trigger":"hash_user","log_exposures":true,"exposure_id":155868813314},"channels_history_cache":{"experiment_id":"145699556609","type":"user","group":"control","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"ios_offline_read_marking_2":{"experiment_id":"173210517495","type":"user","group":"offline_read_marking_enabled","trigger":"launch_user","log_exposures":false,"exposure_id":155868813314},"logstash_calls_js_logs":{"experiment_id":"175371780071","type":"user","group":"enabled","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"search_boost_context":{"experiment_id":"177710356614","type":"user","group":"control","trigger":"hash_user","log_exposures":true,"exposure_id":155868813314},"giovanna_test":{"experiment_id":"181800772038","type":"user","group":"","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"calls_electron_webrtc":{"experiment_id":"187417103495","type":"user","group":"enabled","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"rate_limit_login_by_user_email":{"experiment_id":"190131408354","type":"user","group":"treatment","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"calls_min_bandwidth":{"experiment_id":"190858373799","type":"user","group":"enabled","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"rate_limit_login_by_ip_and_id":{"experiment_id":"194465508597","type":"user","group":"","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"calls_webgl_recovery":{"experiment_id":"201538012262","type":"user","group":"enabled","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"sli_channel_insights":{"experiment_id":"202656182946","type":"user","group":"sli_channel_insights","trigger":"launch_user","log_exposures":false,"exposure_id":155868813314},"app_space_coachmark_copy":{"experiment_id":"205900640787","type":"user","group":"version_a","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"calls_min_bandwidth_moar":{"experiment_id":"208184370230","type":"user","group":"bw_1250","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"early_incr_boot":{"experiment_id":"215725968548","type":"user","group":"control","trigger":"hash_user","log_exposures":true,"exposure_id":155868813314},"sli_channel_insights_dark":{"experiment_id":"228821173360","type":"user","group":"control","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"sli_search_ranking_files_trained":{"experiment_id":"240703115856","type":"user","group":"trained","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"message_ranking_top_results":{"experiment_id":"249404098640","type":"user","group":"model_7","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"ios_show_join_beta_button":{"experiment_id":"250307167730","type":"user","group":"treatment","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"quick_promo_invite_nudge_2":{"experiment_id":"254763892659","type":"user","group":"control","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"app_suggest_link_buttons":{"experiment_id":"259586206071","type":"user","group":"link_buttons","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"sli_search_simplify_top_results":{"experiment_id":"261222155988","type":"user","group":"simplify","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"calls_p2p":{"experiment_id":"268736416752","type":"user","group":"enabled","trigger":"launch_user","log_exposures":false,"exposure_id":155868813314},"unified_autocomplete":{"experiment_id":"270095428551","type":"user","group":"unified","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"email_i18n_reactivation":{"experiment_id":"275337392980","type":"user","group":"control","trigger":"hash_user","log_exposures":true,"exposure_id":155868813314},"email_i18n_reactivation_v2":{"experiment_id":"276058626338","type":"user","group":"treatment","trigger":"launch_user","log_exposures":false,"exposure_id":155868813314},"onboarding_2_skip":{"experiment_id":"279490891602","type":"user","group":"show_skip","trigger":"hash_user","log_exposures":true,"exposure_id":155868813314},"calls_disable_startup_thumbnails":{"experiment_id":"283143712310","type":"user","group":"enabled","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"calls_disable_widescreen":{"experiment_id":"289910614965","type":"user","group":"enabled","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"autocomplete_files":{"experiment_id":"299214220897","type":"user","group":"experimental","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"sli_channel_archive_suggestions":{"experiment_id":"303678001734","type":"user","group":"sli_channel_archive_suggestions","trigger":"launch_user","log_exposures":false,"exposure_id":155868813314},"autocomplete_suggestion_length":{"experiment_id":"306300085110","type":"user","group":"control","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"calls_create_attach_join":{"experiment_id":"307534845478","type":"user","group":"enabled","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"sli_search_refinements":{"experiment_id":"310733255011","type":"user","group":"control","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"sli_search_refinement_query_solr":{"experiment_id":"310853463040","type":"user","group":"control","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"sli_search_autocomplete_ranking":{"experiment_id":"314582940432","type":"user","group":"lambda_rank","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"native_app_start":{"experiment_id":"315357962818","type":"user","group":"control","trigger":"hash_user","log_exposures":true,"exposure_id":155868813314},"search_chat_solrcloud_experiment":{"experiment_id":"316326569424","type":"user","group":"solrcloud","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"sli_refinements_low_results":{"experiment_id":"319377370114","type":"user","group":"control","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"calls_cmd_tab":{"experiment_id":"320504100865","type":"user","group":"enabled","trigger":"launch_user","log_exposures":false,"exposure_id":155868813314},"sli_refinements_spell_only":{"experiment_id":"321169193588","type":"user","group":"control","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"sli_search_ac_diversify":{"experiment_id":"322522331094","type":"user","group":"control","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"solr_cache_team_fq":{"experiment_id":"323429393127","type":"user","group":"control","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"search_precache":{"experiment_id":"325778633617","type":"user","group":"treatment","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"sli_default_sorting":{"experiment_id":"328562838083","type":"user","group":"control","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"sli_fq_terms_query":{"experiment_id":"329956479699","type":"user","group":"control","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"solr_simplify_filters":{"experiment_id":"330596354005","type":"user","group":"control","trigger":"hash_user","log_exposures":true,"exposure_id":155868813314},"sli_all_tab":{"experiment_id":"332269941778","type":"user","group":"control","trigger":"finished","log_exposures":false,"exposure_id":155868813314},"content_available":{"experiment_id":"333229683522","type":"user","group":"treatment","trigger":"launch_user","log_exposures":false,"exposure_id":155868813314},"social_nudge_v0":{"experiment_id":"57452636336","type":"team","group":"","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"migrate_stats_to_cds":{"experiment_id":"70039090853","type":"team","group":"stats_cds","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"migrate_stats_enable_dark_reads":{"experiment_id":"70047028338","type":"team","group":"stats_mysql_and_cds_dark_reads","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"domain_signup_links_for_mobile":{"experiment_id":"70804845972","type":"team","group":"treatment","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"update_invite_coachmarks_cta":{"experiment_id":"84280109270","type":"team","group":"invite_cm_got_ita","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"google_contacts_invite_existing":{"experiment_id":"93086200404","type":"team","group":"google_contacts","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"google_contacts_invite_new":{"experiment_id":"93096027173","type":"team","group":"","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"calls_ss":{"experiment_id":"115254301153","type":"team","group":"enabled","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"app_suggestions_round_2":{"experiment_id":"131240436582","type":"team","group":"no_suggestions","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"email_autocomplete_android":{"experiment_id":"133221212662","type":"team","group":"enabled","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"modal_3_fields":{"experiment_id":"140209149492","type":"team","group":"modal_3_fields","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"modal_3_fields_existing_teams":{"experiment_id":"142775007765","type":"team","group":"modal_3_fields","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"guest_profiles_and_expiration":{"experiment_id":"145034475616","type":"team","group":"treatment","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"exp_thread_at_mention":{"experiment_id":"145686678499","type":"team","group":"autofill","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"exp_threads_everything_pref":{"experiment_id":"152393699186","type":"team","group":"show_banner","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"lib_mentions_match":{"experiment_id":"153633324374","type":"team","group":"trie","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"app_dir_channel_sidebar_cta":{"experiment_id":"159072431845","type":"team","group":"control","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"rebuild_mention_map_double_write":{"experiment_id":"164525064375","type":"team","group":"yes","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"tell_joiners_about_joiners":{"experiment_id":"164588156482","type":"team","group":"send_joiners_pushes","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"email_joiners_about_joiners":{"experiment_id":"169717077127","type":"team","group":"send_joiners_emails","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"rebuild_mention_map_with_job":{"experiment_id":"174477577986","type":"team","group":"job","trigger":"launch_team","log_exposures":false,"exposure_id":155191149137},"guest_expiration_announcement":{"experiment_id":"175209361220","type":"team","group":"whats_new","trigger":"launch_team","log_exposures":false,"exposure_id":155191149137},"edit_team_status_presets":{"experiment_id":"176895283504","type":"team","group":"treatment","trigger":"launch_team","log_exposures":false,"exposure_id":155191149137},"calls_interactive_ss":{"experiment_id":"194479526932","type":"team","group":"enabled","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"pricing_page_v2_2_signedin":{"experiment_id":"199590432480","type":"team","group":"treatment","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"slackbot_help_v2_buttons":{"experiment_id":"200318583393","type":"team","group":"treatment","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"calls_electron_webrtc_linux":{"experiment_id":"200944175600","type":"team","group":"enabled","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"instant_invite_link_ios":{"experiment_id":"201626291921","type":"team","group":"enabled","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"feat_onepage_signup_v2":{"experiment_id":"205971003682","type":"team","group":"single_page","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"feat_limit_meters":{"experiment_id":"212162225108","type":"team","group":"show_limit_meters","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"self_serve_invoicing_checkout":{"experiment_id":"222019723543","type":"team","group":"treatment","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"newxp_onboarding_2_0":{"experiment_id":"235196062839","type":"team","group":"treatment","trigger":"launch_team","log_exposures":false,"exposure_id":155191149137},"feat_msg_lim_search":{"experiment_id":"246809624001","type":"team","group":"control","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"email_app_onboard_all":{"experiment_id":"252073272226","type":"team","group":"treatment","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"email_app_onboard_admins":{"experiment_id":"252209807013","type":"team","group":"treatment","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"shared_channels_trial_flow":{"experiment_id":"257137512243","type":"team","group":"treatment","trigger":"hash_team","log_exposures":true,"exposure_id":155191149137},"newxp_tips_loading_messages":{"experiment_id":"264238720563","type":"team","group":"treatment","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"small_feat_list":{"experiment_id":"264419561860","type":"team","group":"treatment","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"email_slack_certification":{"experiment_id":"265884802150","type":"team","group":"control","trigger":"hash_team","log_exposures":true,"exposure_id":155191149137},"no_content_avails":{"experiment_id":"272365364819","type":"team","group":"treatment","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"calls_orca_team":{"experiment_id":"272550881573","type":"team","group":"enabled","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"email_post_upgrade_onboard":{"experiment_id":"273987023266","type":"team","group":"control","trigger":"hash_team","log_exposures":true,"exposure_id":155191149137},"less_android_badges":{"experiment_id":"274765772358","type":"team","group":"treatment","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"replace_billing_link":{"experiment_id":"276628623189","type":"team","group":"has_plans_link","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"apns2":{"experiment_id":"279378859908","type":"team","group":"","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"free_trial_in_prod":{"experiment_id":"281625415173","type":"team","group":"banner_and_email","trigger":"hash_team","log_exposures":true,"exposure_id":155191149137},"apns2_part_2":{"experiment_id":"283505922689","type":"team","group":"","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"apns_collapse":{"experiment_id":"286616632582","type":"team","group":"","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"install_apps_link":{"experiment_id":"293721709264","type":"team","group":"","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"test_free_trial_in_prod":{"experiment_id":"300479776051","type":"team","group":"banner_and_email","trigger":"hash_team","log_exposures":true,"exposure_id":155191149137},"self_serve_sfdc_leads":{"experiment_id":"300549613556","type":"team","group":"treatment","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"email_sfmc_team_joiner_welcome":{"experiment_id":"305390696324","type":"team","group":"treatment","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"enforce_5gb_file_limit":{"experiment_id":"309141027571","type":"team","group":"control","trigger":"hash_team","log_exposures":true,"exposure_id":155191149137},"checkout_emphasize_total_cost":{"experiment_id":"311504791394","type":"team","group":"treatment","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"drift_on_plans_page":{"experiment_id":"312235426720","type":"team","group":"treatment","trigger":"hash_team","log_exposures":true,"exposure_id":155191149137},"calls_callstats":{"experiment_id":"313435842625","type":"team","group":"disabled","trigger":"finished","log_exposures":false,"exposure_id":155191149137},"prompt_to_expand_2":{"experiment_id":"315869208724","type":"team","group":"treatment","trigger":"hash_team","log_exposures":true,"exposure_id":155191149137},"checkout_detailed_confirm":{"experiment_id":"327497906467","type":"team","group":"control","trigger":"hash_team","log_exposures":true,"exposure_id":155191149137},"approaching_file_limit_banner":{"experiment_id":"331827143204","type":"team","group":"control","trigger":"hash_team","log_exposures":true,"exposure_id":155191149137},"logged_in_standard_page":{"experiment_id":"336448536561","type":"team","group":"control","trigger":"hash_team","log_exposures":true,"exposure_id":155191149137}};
			
	// inline_emoji
	boot_data.pref_emoji_mode = "default";
	boot_data.pref_jumbomoji = 1;
	boot_data.pref_messages_theme = "default";

//-->
</script>
		





	<!-- output_js "libs" -->
<script type="text/javascript" src="https://a.slack-edge.com/bv1-1/emoji_5.f765b7e9a668291cfd7b.min.js" crossorigin="anonymous" onload="window._cdn && _cdn.ok(this, arguments)" onerror="window._cdn && _cdn.failed(this, arguments)"></script>
<script type="text/javascript" src="https://a.slack-edge.com/bv1-1/rollup-core_required_libs.c0dc38f60627b10d1857.min.js" crossorigin="anonymous" onload="window._cdn && _cdn.ok(this, arguments)" onerror="window._cdn && _cdn.failed(this, arguments)"></script>

	<!-- output_js "application" -->
<script type="text/javascript" src="https://a.slack-edge.com/bv1-1/modern.vendor.1e4e1df44a30ab12474d.min.js" crossorigin="anonymous" onload="window._cdn && _cdn.ok(this, arguments)" onerror="window._cdn && _cdn.failed(this, arguments)"></script>
<script type="text/javascript" src="https://a.slack-edge.com/bv1-1/application.46e1936abb3476f539a1.min.js" crossorigin="anonymous" onload="window._cdn && _cdn.ok(this, arguments)" onerror="window._cdn && _cdn.failed(this, arguments)"></script>

	<!-- output_js "page" -->

		<!-- output_js "core" -->
<script type="text/javascript" src="https://a.slack-edge.com/bv1-1/rollup-core_required_ts.6bb3a1ecc74f453613c0.min.js" crossorigin="anonymous" onload="window._cdn && _cdn.ok(this, arguments)" onerror="window._cdn && _cdn.failed(this, arguments)"></script>
<script type="text/javascript" src="https://a.slack-edge.com/bv1-1/TS.web.c26817630f334be92695.min.js" crossorigin="anonymous" onload="window._cdn && _cdn.ok(this, arguments)" onerror="window._cdn && _cdn.failed(this, arguments)"></script>

	<!-- output_js "core_web" -->
<script type="text/javascript" src="https://a.slack-edge.com/bv1-1/rollup-core_web.1143ba1e81bc299b8a51.min.js" crossorigin="anonymous" onload="window._cdn && _cdn.ok(this, arguments)" onerror="window._cdn && _cdn.failed(this, arguments)"></script>

	<!-- output_js "secondary" -->
<script type="text/javascript" src="https://a.slack-edge.com/bv1-1/rollup-secondary_a_required.b5a469ac10a64605fdfb.min.js" crossorigin="anonymous" onload="window._cdn && _cdn.ok(this, arguments)" onerror="window._cdn && _cdn.failed(this, arguments)"></script>
<script type="text/javascript" src="https://a.slack-edge.com/bv1-1/rollup-secondary_b_required.8266e43005c1d47c33bd.min.js" crossorigin="anonymous" onload="window._cdn && _cdn.ok(this, arguments)" onerror="window._cdn && _cdn.failed(this, arguments)"></script>

				
	
	<script type="text/javascript">TS.boot(boot_data);</script>

	<!-- output_js "regular" -->
<script type="text/javascript" src="https://a.slack-edge.com/bv1-1/TS.web.comments.996f8252f56873b76f97.min.js" crossorigin="anonymous" onload="window._cdn && _cdn.ok(this, arguments)" onerror="window._cdn && _cdn.failed(this, arguments)"></script>
<script type="text/javascript" src="https://a.slack-edge.com/bv1-1/TS.web.file.ae468a11c71f43e729fc.min.js" crossorigin="anonymous" onload="window._cdn && _cdn.ok(this, arguments)" onerror="window._cdn && _cdn.failed(this, arguments)"></script>
<script type="text/javascript" src="https://a.slack-edge.com/bv1-1/codemirror.min.44a2b0ae2d7a5cac8a95.min.js" crossorigin="anonymous" onload="window._cdn && _cdn.ok(this, arguments)" onerror="window._cdn && _cdn.failed(this, arguments)"></script>
<script type="text/javascript" src="https://a.slack-edge.com/bv1-1/codemirror_simple.9c76f7896754967b9eda.min.js" crossorigin="anonymous" onload="window._cdn && _cdn.ok(this, arguments)" onerror="window._cdn && _cdn.failed(this, arguments)"></script>
<script type="text/javascript" src="https://a.slack-edge.com/bv1-1/codemirror_load.5afece10ceabb3d91968.min.js" crossorigin="anonymous" onload="window._cdn && _cdn.ok(this, arguments)" onerror="window._cdn && _cdn.failed(this, arguments)"></script>


			<script type="text/javascript">
	<!--
		boot_data.page_needs_custom_emoji = true;

		boot_data.file = {"id":"F6YBQU7C3","created":1504630843,"timestamp":1504630843,"name":"GenerateSeedInt.cs","title":"GenerateSeedInt.cs","mimetype":"text\/plain","filetype":"csharp","pretty_type":"C#","user":"U4KRJPX98","editable":true,"size":1034,"mode":"snippet","is_external":false,"external_type":"","is_public":true,"public_url_shared":false,"display_as_bot":false,"username":"","url_private":"https:\/\/files.slack.com\/files-pri\/T4K5M4D41-F6YBQU7C3\/generateseedint.cs","url_private_download":"https:\/\/files.slack.com\/files-pri\/T4K5M4D41-F6YBQU7C3\/download\/generateseedint.cs","permalink":"https:\/\/playmakertalk.slack.com\/files\/U4KRJPX98\/F6YBQU7C3\/generateseedint.cs","permalink_public":"https:\/\/slack-files.com\/T4K5M4D41-F6YBQU7C3-e6d850281a","edit_link":"https:\/\/playmakertalk.slack.com\/files\/U4KRJPX98\/F6YBQU7C3\/generateseedint.cs\/edit","preview":"using UnityEngine;\nusing System.Collections;\nusing Experilous.MakeItRandom;\n\nnamespace HutongGames.PlayMaker.Actions","preview_highlight":"\u003Cdiv class=\"CodeMirror cm-s-default CodeMirrorServer\" oncopy=\"if(event.clipboardData){event.clipboardData.setData('text\/plain',window.getSelection().toString().replace(\/\\u200b\/g,''));event.preventDefault();event.stopPropagation();}\"\u003E\n\u003Cdiv class=\"CodeMirror-code\"\u003E\n\u003Cdiv\u003E\u003Cpre\u003E\u003Cspan class=\"cm-keyword\"\u003Eusing\u003C\/span\u003E \u003Cspan class=\"cm-variable\"\u003EUnityEngine\u003C\/span\u003E;\u003C\/pre\u003E\u003C\/div\u003E\n\u003Cdiv\u003E\u003Cpre\u003E\u003Cspan class=\"cm-keyword\"\u003Eusing\u003C\/span\u003E \u003Cspan class=\"cm-variable\"\u003ESystem\u003C\/span\u003E.\u003Cspan class=\"cm-variable\"\u003ECollections\u003C\/span\u003E;\u003C\/pre\u003E\u003C\/div\u003E\n\u003Cdiv\u003E\u003Cpre\u003E\u003Cspan class=\"cm-keyword\"\u003Eusing\u003C\/span\u003E \u003Cspan class=\"cm-variable\"\u003EExperilous\u003C\/span\u003E.\u003Cspan class=\"cm-variable\"\u003EMakeItRandom\u003C\/span\u003E;\u003C\/pre\u003E\u003C\/div\u003E\n\u003Cdiv\u003E\u003Cpre\u003E&#8203;\u003C\/pre\u003E\u003C\/div\u003E\n\u003Cdiv\u003E\u003Cpre\u003E\u003Cspan class=\"cm-keyword\"\u003Enamespace\u003C\/span\u003E \u003Cspan class=\"cm-def\"\u003EHutongGames\u003C\/span\u003E.\u003Cspan class=\"cm-variable\"\u003EPlayMaker\u003C\/span\u003E.\u003Cspan class=\"cm-variable\"\u003EActions\u003C\/span\u003E\u003C\/pre\u003E\u003C\/div\u003E\n\u003C\/div\u003E\n\u003C\/div\u003E\n","lines":57,"lines_more":52,"preview_is_truncated":true,"channels":["C4KU5EU3F"],"groups":[],"ims":[],"comments_count":1,"reactions":[{"name":"+1","users":["U9SA45Q76"],"count":1}]};
		boot_data.file.comments = [{"id":"FcA31BJDNX","created":1523195079,"timestamp":1523195079,"user":"U4KRJPX98","is_intro":false,"comment":"2"}];

		

		var g_editor;

		var code_wrap_long_lines = true;

		$(function(){

			var wrap_long_lines = !!code_wrap_long_lines;

			g_editor = CodeMirror(function(elt){
				var content = document.getElementById("file_contents");
				content.parentNode.replaceChild(elt, content);
			}, {
				value: $('#file_contents').text(),
				lineNumbers: true,
				matchBrackets: true,
				indentUnit: 4,
				indentWithTabs: true,
				enterMode: "keep",
				tabMode: "shift",
				viewportMargin: 10,
				readOnly: true,
				lineWrapping: wrap_long_lines
			});

			// past a certain point, CodeMirror rendering may simply stop working.
			// start having CodeMirror use its Long List View-style scolling at >= max_lines.
			var max_lines = 8192;

			var snippet_lines;

			// determine # of lines, limit height accordingly
			if (g_editor.doc && g_editor.doc.lineCount) {
				snippet_lines = parseInt(g_editor.doc.lineCount());
				var new_height;
				if (snippet_lines) {
					// we want the CodeMirror container to collapse around short snippets.
					// however, we want to let it auto-expand only up to a limit, at which point
					// we specify a fixed height so CM can display huge snippets without dying.
					// this is because CodeMirror works nicely with no height set, but doesn't
					// scale (big file performance issue), and doesn't work with min/max-height -
					// so at some point, we have to set an absolute height to kick it into its
					// smart / partial "Long List View"-style rendering mode.
					if (snippet_lines < max_lines) {
						new_height = 'auto';
					} else {
						new_height = (max_lines * 0.875) + 'rem'; // line-to-rem ratio
					}
					var line_count = Math.min(snippet_lines, max_lines);
					TS.info('Applying height of ' + new_height + ' to container for this snippet of ' + snippet_lines + (snippet_lines === 1 ? ' line' : ' lines'));
					$('#page .CodeMirror').height(new_height);
				}
			}

			$('#file_preview_wrap_cb').bind('change', function(e) {
				code_wrap_long_lines = $(this).prop('checked');
				g_editor.setOption('lineWrapping', code_wrap_long_lines);
			})

			$('#file_preview_wrap_cb').prop('checked', wrap_long_lines);

			CodeMirror.switchSlackMode(g_editor, "csharp");
		});

		
		$('#file_comment').css('overflow', 'hidden').autogrow();
	//-->
	</script>


<style>.color_9f69e7:not(.nuc) {color:#9F69E7;}.color_4bbe2e:not(.nuc) {color:#4BBE2E;}.color_e7392d:not(.nuc) {color:#E7392D;}.color_3c989f:not(.nuc) {color:#3C989F;}.color_674b1b:not(.nuc) {color:#674B1B;}.color_e96699:not(.nuc) {color:#E96699;}.color_e0a729:not(.nuc) {color:#E0A729;}.color_684b6c:not(.nuc) {color:#684B6C;}.color_5b89d5:not(.nuc) {color:#5B89D5;}.color_2b6836:not(.nuc) {color:#2B6836;}.color_99a949:not(.nuc) {color:#99A949;}.color_df3dc0:not(.nuc) {color:#DF3DC0;}.color_4cc091:not(.nuc) {color:#4CC091;}.color_9b3b45:not(.nuc) {color:#9B3B45;}.color_d58247:not(.nuc) {color:#D58247;}.color_bb86b7:not(.nuc) {color:#BB86B7;}.color_5a4592:not(.nuc) {color:#5A4592;}.color_db3150:not(.nuc) {color:#DB3150;}.color_235e5b:not(.nuc) {color:#235E5B;}.color_9e3997:not(.nuc) {color:#9E3997;}.color_53b759:not(.nuc) {color:#53B759;}.color_c386df:not(.nuc) {color:#C386DF;}.color_385a86:not(.nuc) {color:#385A86;}.color_a63024:not(.nuc) {color:#A63024;}.color_5870dd:not(.nuc) {color:#5870DD;}.color_ea2977:not(.nuc) {color:#EA2977;}.color_50a0cf:not(.nuc) {color:#50A0CF;}.color_d55aef:not(.nuc) {color:#D55AEF;}.color_d1707d:not(.nuc) {color:#D1707D;}.color_43761b:not(.nuc) {color:#43761B;}.color_e06b56:not(.nuc) {color:#E06B56;}.color_8f4a2b:not(.nuc) {color:#8F4A2B;}.color_902d59:not(.nuc) {color:#902D59;}.color_de5f24:not(.nuc) {color:#DE5F24;}.color_a2a5dc:not(.nuc) {color:#A2A5DC;}.color_827327:not(.nuc) {color:#827327;}.color_3c8c69:not(.nuc) {color:#3C8C69;}.color_8d4b84:not(.nuc) {color:#8D4B84;}.color_84b22f:not(.nuc) {color:#84B22F;}.color_4ec0d6:not(.nuc) {color:#4EC0D6;}.color_e23f99:not(.nuc) {color:#E23F99;}.color_e475df:not(.nuc) {color:#E475DF;}.color_619a4f:not(.nuc) {color:#619A4F;}.color_a72f79:not(.nuc) {color:#A72F79;}.color_7d414c:not(.nuc) {color:#7D414C;}.color_aba727:not(.nuc) {color:#ABA727;}.color_965d1b:not(.nuc) {color:#965D1B;}.color_4d5e26:not(.nuc) {color:#4D5E26;}.color_dd8527:not(.nuc) {color:#DD8527;}.color_bd9336:not(.nuc) {color:#BD9336;}.color_e85d72:not(.nuc) {color:#E85D72;}.color_dc7dbb:not(.nuc) {color:#DC7DBB;}.color_bc3663:not(.nuc) {color:#BC3663;}.color_9d8eee:not(.nuc) {color:#9D8EEE;}.color_8469bc:not(.nuc) {color:#8469BC;}.color_73769d:not(.nuc) {color:#73769D;}.color_b14cbc:not(.nuc) {color:#B14CBC;}</style>

<!-- slack-www-hhvm-0d517b975d76b8c32 / 2018-04-08 07:11:38 / v1080460bbd9e2157c4f3eac8edfc2e3e336cc20b / B:H -->


</body>
</html>